using Scheduleator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployeeView : Window, INotifyPropertyChanged
    {
        ObservableCollection<Shift> DayOne = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DayTwo = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DayThree = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DayFour = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DayFive = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DaySix = new ObservableCollection<Shift>();
        ObservableCollection<Shift> DaySeven = new ObservableCollection<Shift>();
        DateTime StartDate;
        Employee User;
        Shift _SelectedShift;
        ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();

        public event PropertyChangedEventHandler PropertyChanged;

        public Shift SelectedShift { get => _SelectedShift;
            set {
                _SelectedShift = value;
                OnPropertyChanged(nameof(SelectedShift));
            }
        }

        public EmployeeView(Employee employee)
        {
            InitializeComponent();
            this.DataContext = this;
            StartDate = DateTime.Today;
            _ConsoleViewModel.InitializeViewModelData();
            List<Shift> temp = _ConsoleViewModel.ShiftList();
            User = employee;
            SetListView(temp);


        }
        public void SetListView(List<Shift> temp)
        {
            foreach (Shift x in temp)
            {
                if (x.StartTime.Date == StartDate)
                    DayOne.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(1))
                    DayTwo.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(2))
                    DayThree.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(3))
                    DayFour.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(4))
                    DayFive.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(5))
                    DaySix.Add(x);
                if (x.StartTime.Date == StartDate.AddDays(6))
                    DaySeven.Add(x);




            }
            //Shifts shifts = new Shifts(temp);
            SundayList.ItemsSource = DayOne;
            MondayList.ItemsSource = DayTwo;
            TuesdayList.ItemsSource = DayThree;
            WednesdayList.ItemsSource = DayFour;
            ThursdayList.ItemsSource = DayFive;
            FridayList.ItemsSource = DaySix;
            SaturdayList.ItemsSource = DaySeven;
            //Setting the Labels
            One.DataContext = StartDate;
            Two.DataContext = StartDate.AddDays(1);
            Three.DataContext = StartDate.AddDays(2);
            Four.DataContext = StartDate.AddDays(3);
            Five.DataContext = StartDate.AddDays(4);
            Six.DataContext = StartDate.AddDays(5);
            Seven.DataContext = StartDate.AddDays(6);
            String pre = "<<";
            Previous.DataContext = pre;
            String next = ">>";
            Next.DataContext = next;
        }
        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            StartDate = StartDate.AddDays(-7);
            _ConsoleViewModel.InitializeViewModelData();
            List<Shift> nextList = _ConsoleViewModel.ShiftList();
            DayOne.Clear();
            DayTwo.Clear();
            DayThree.Clear();
            DayFour.Clear();
            DayFive.Clear();
            DaySix.Clear();
            DaySeven.Clear();
            SetListView(nextList);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            StartDate = StartDate.AddDays(7);
            _ConsoleViewModel.InitializeViewModelData();
            List<Shift> nextList = _ConsoleViewModel.ShiftList();
            DayOne.Clear();
            DayTwo.Clear();
            DayThree.Clear();
            DayFour.Clear();
            DayFive.Clear();
            DaySix.Clear();
            DaySeven.Clear();
            SetListView(nextList);

        }
        private void ShiftClicked(object sender, SelectionChangedEventArgs e)
        {
            if(SelectedShift != null)
            {
                ShiftInfo shiftInfo = new ShiftInfo(SelectedShift, User);
                shiftInfo.ShowDialog();
            }
            SelectedShift = null;
            return;
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

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            
            EmployeeProfile employeeProfile = new EmployeeProfile(User);
            employeeProfile.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("\r\nDo you want to exit?\r\n", "Exiting..", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
