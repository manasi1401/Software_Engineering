using Scheduleator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeUI
{
    /// <summary>
    /// Interaction logic for ShiftInfo.xaml
    /// </summary>
    public partial class ShiftInfo : Window, INotifyPropertyChanged
    {
        private ConsoleViewModel _ConsoleViewModel;
        private Shift _SelectedSchedule;
        private Employee _CurrentUser;
        private bool _IsNotAvailable;
        private bool _IsAvailable;
        private long _Shift_Id;
        private string _DateOfShift;
        private string _Start_Time;
        private string _End_Time;

        public event PropertyChangedEventHandler PropertyChanged;

        public ShiftInfo(Shift shift, Employee employee)
        {
            InitializeComponent();
            SelectedSchedule = shift;
            CurrentUser = employee;
            _ConsoleViewModel = new ConsoleViewModel();
            _ConsoleViewModel.InitializeViewModelData();
            Shift_Id = SelectedSchedule.ShiftID;
            DateOfShift = SelectedSchedule.DateOfShift.ToShortDateString();
            Start_Time_ = SelectedSchedule.StartTime.ToShortTimeString();
            End_Time_ = SelectedSchedule.EndTime.ToShortTimeString();

            if (SelectedSchedule.AvailableEmployees.Exists(x => x.ID == _CurrentUser.ID) == true)
            {
                IsAvailable = true;
                IsNotAvailable = !IsAvailable;
            }
            else
            {
                IsAvailable = false;
                IsNotAvailable = !IsAvailable;
            }


            this.DataContext = this;

        }

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

        public long Shift_Id {
            get => _Shift_Id;
            set => _Shift_Id = value;
        }
        public string DateOfShift {
            get => _DateOfShift;
            set => _DateOfShift = value;
        }
        public string Start_Time_ {
            get => _Start_Time;
            set => _Start_Time = value;
        }
        public string End_Time_ {
            get => _End_Time;
            set => _End_Time = value;
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

        public Shift SelectedSchedule { get => _SelectedSchedule; set => _SelectedSchedule = value; }
        public Employee CurrentUser { get => _CurrentUser; set => _CurrentUser = value; }
       
     

        private void rdAvailable_Checked(object sender, RoutedEventArgs e)
        {
            if (SelectedSchedule.AvailableEmployees.Exists(x => x.ID == _CurrentUser.ID) == false)
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

        private void DoneSelected(object sender, RoutedEventArgs e)
        {
            //EmployeeView employeeView = new EmployeeView(_CurrentUser);
            this.Close();
            //employeeView.ShowDialog();

        }
    }
}
