using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Scheduleator
{
    public partial class ManageShifts : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ConsoleViewModel _ConsoleViewModel;
        private ObservableCollection<Shift> _AvailableShifts = new ObservableCollection<Shift>();
        private Shift _SelectedSchedule;
        private List<Employee> ListOfAvailableEmployees;
        private Employee _CurrentUser;
        private string _NameOfCurrentUser;

        private bool _IsNotAvailable;
        private bool _IsAvailable;

        public bool IsNotAvailable
        {
            get { return _IsNotAvailable; }
            set
            {
                _IsNotAvailable = value;
                OnPropertyChanged(nameof(IsNotAvailable));
            }
        }

        public bool IsAvailable
        {
            get { return _IsAvailable; }
            set
            {
                _IsAvailable = value;
                OnPropertyChanged(nameof(IsAvailable));
            }
        }

        public ManageShifts(Employee CurrentUser)
        {
            InitializeComponent();
            _ConsoleViewModel = new ConsoleViewModel();
            _ConsoleViewModel.InitializeViewModelData();

            AvailableShifts = new ObservableCollection<Shift>(_ConsoleViewModel.HolderData.CreatedShifts.OrderBy(x=>x.StartTime));
            _CurrentUser = CurrentUser;
            NameOfCurrentUser = CurrentUser.UserName;

            SelectedSchedule = _AvailableShifts.FirstOrDefault<Shift>();

            DateOfShift = SelectedSchedule.DateOfShift.ToShortDateString();
            StartTimeShift = SelectedSchedule.StartTimeFormatted;
            EndTimeShift = SelectedSchedule.EndTimeFormatted;

            ListOfAvailableEmployees = SelectedSchedule.AvailableEmployees.Where<Employee>(employee => employee.ID == _CurrentUser.ID).ToList<Employee>();

            if(ListOfAvailableEmployees.Count == 0)
            {
                IsAvailable = false;
                IsNotAvailable = !IsAvailable;
            }
            else
            {
                IsAvailable = true;
                IsNotAvailable = !IsAvailable;
            }

            this.DataContext = this;
        }

        private void btnDoneWithManaging_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lstScheduleView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DateOfShift = SelectedSchedule.DateOfShift.ToShortDateString();
            StartTimeShift = SelectedSchedule.StartTimeFormatted;
            EndTimeShift = SelectedSchedule.EndTimeFormatted;

            ListOfAvailableEmployees = SelectedSchedule.AvailableEmployees.Where<Employee>(employee => employee.ID == _CurrentUser.ID).ToList<Employee>();

            if (ListOfAvailableEmployees.Count == 0)
            {
                IsAvailable = false;
                IsNotAvailable = !IsAvailable;
            }
            else
            {
                IsAvailable = true;
                IsNotAvailable = !IsAvailable;
            }
        }

        public string NameOfCurrentUser
        {
            get { return _NameOfCurrentUser; }
            set
            {
                _NameOfCurrentUser = value;
                _NameOfCurrentUser = "Current User:\r\n" + _NameOfCurrentUser;
                OnPropertyChanged(nameof(NameOfCurrentUser));
            }
        }

        private string _DateOfShift;
        private string _StartTimeShift;
        private string _EndTimeShift;

        public string EndTimeShift
        {
            get { return _EndTimeShift; }
            set
            {
                _EndTimeShift = value;
                _EndTimeShift = "End Time: " + _EndTimeShift;
                OnPropertyChanged(nameof(EndTimeShift));
            }
        }

        public string StartTimeShift
        {
            get { return _StartTimeShift; }
            set
            {
                _StartTimeShift = value;
                _StartTimeShift = "Start Time: " + _StartTimeShift;
                OnPropertyChanged(nameof(StartTimeShift));
            }
        }

        public string DateOfShift
        {
            get { return _DateOfShift; }
            set
            {
                _DateOfShift = value;
                _DateOfShift = "Date: " + _DateOfShift;
                OnPropertyChanged(nameof(DateOfShift));
            }
        }

        public Shift SelectedSchedule
        {
            get { return _SelectedSchedule; }
            set
            {
                _SelectedSchedule = value;
                OnPropertyChanged(nameof(SelectedSchedule));
            }
        }

        public ObservableCollection<Shift> AvailableShifts
        {
            get { return _AvailableShifts; }
            set
            {
                _AvailableShifts = value;
                OnPropertyChanged(nameof(AvailableShifts));
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        private void rdAvailable_Checked(object sender, RoutedEventArgs e)
        {
            // put on available list
            if (SelectedSchedule.AvailableEmployees.Exists(x=> x.ID ==_CurrentUser.ID)==false) 
                 SelectedSchedule.AvailableEmployees.Add(_CurrentUser);
            List<Shift> ShiftList = _ConsoleViewModel.ShiftList();
            int index = ShiftList.FindIndex(x => x.ShiftID.Equals(SelectedSchedule.ShiftID));
            _ConsoleViewModel.DeleteFromShiftList(index);
            _ConsoleViewModel.AddShift(SelectedSchedule);
            _ConsoleViewModel.SaveScheduleProgress();
            _ConsoleViewModel.InitializeViewModelData();
        }

        private void rdNotAvailable_Checked(object sender, RoutedEventArgs e)
        {
            // remove from available list
            List<Employee> listComingBack = new List<Employee>();
            listComingBack = SelectedSchedule.AvailableEmployees.Where(s => s.ID == _CurrentUser.ID).ToList<Employee>();

            Employee employeeToRemove;

            if (listComingBack.Count != 0)
            {
                employeeToRemove = listComingBack.FirstOrDefault<Employee>();
                SelectedSchedule.AvailableEmployees.Remove(employeeToRemove);
                List<Shift> ShiftList = _ConsoleViewModel.ShiftList();
                int index = ShiftList.FindIndex(x => x.ShiftID.Equals(SelectedSchedule.ShiftID));
                _ConsoleViewModel.DeleteFromShiftList(index);
                _ConsoleViewModel.AddShift(SelectedSchedule);
            _ConsoleViewModel.SaveScheduleProgress();
            _ConsoleViewModel.InitializeViewModelData();
            }
        }
    }
}