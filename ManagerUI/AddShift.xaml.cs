using System;
using System.Collections.Generic;
using System.Windows;

namespace Scheduleator
{
    public partial class AddShift : Window
    {
        #region Member Variables
        private AddShiftViewModel addShiftViewModel;
        private Shift newShift;
        private ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
        #endregion

        #region Constructor
        public AddShift()
        {
            InitializeComponent();
            addShiftViewModel = new AddShiftViewModel();
            this.DataContext = addShiftViewModel;            
        }
        #endregion

        #region Private Methods
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            newShift = new Shift();

            newShift.NumberOfCashiers = addShiftViewModel.NumberOfCashiers;
            newShift.NumberOfCooks = addShiftViewModel.NumberOfCooks;
            newShift.NumberOfDiswashers = addShiftViewModel.NumberOfDiswashers;
            newShift.NumberOfWaiters = addShiftViewModel.NumberOfWaiters;
            newShift.NumberOfManagers = addShiftViewModel.NumberOfManagers;
            newShift.DateOfShift = addShiftViewModel.ShiftDate;

            int year = newShift.DateOfShift.Year;
            int month = newShift.DateOfShift.Month;
            int day = newShift.DateOfShift.Day;
            int hour = Convert.ToInt32(addShiftViewModel.StartHour);
            int min = Convert.ToInt32(addShiftViewModel.StartMinute);

            newShift.StartTime = new DateTime(year, month, day, hour, min, 0);
            hour = Convert.ToInt32(addShiftViewModel.EndHour);
            min = Convert.ToInt32(addShiftViewModel.EndMinute);
            newShift.EndTime = new DateTime(year, month, day, hour, min, 0);

            _ConsoleViewModel.InitializeViewModelData();

            newShift.ShiftID = newShift.GetHashCode();

            _ConsoleViewModel.AddShift(newShift);

            _ConsoleViewModel.SaveScheduleProgress();

            Shiftviewer shiftviewer = new Shiftviewer();
            shiftviewer.Show();
            this.Close();
            
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Shiftviewer shiftviewer = new Shiftviewer();
            shiftviewer.Show();
            this.Close();
        }

        private void SMinute_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.StartMinute = Int32.Parse(SMinute.SelectedItem.ToString());
        }

        private void StarTimeHour_Loaded(object sender, RoutedEventArgs e)
        {
            int SetHour;
            List<int> StartHours = new List<int>();

            StartHours.Add(00);
            StartHours.Add(01);
            StartHours.Add(02);
            StartHours.Add(03);
            StartHours.Add(04);
            StartHours.Add(05);
            StartHours.Add(06);
            StartHours.Add(07);
            StartHours.Add(08);
            StartHours.Add(09);
            StartHours.Add(10);
            StartHours.Add(11);
            StartHours.Add(12);

            SHour.ItemsSource = StartHours;

            if (addShiftViewModel.StartHour > 12)
            {
                SetHour = addShiftViewModel.StartHour - 12;
            }
            else
            {
                SetHour = addShiftViewModel.StartHour;
            }

            SHour.SelectedItem = SetHour;
        }

        private void StartHourSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.StartHour= Int32.Parse(SHour.SelectedItem.ToString());
        }

        private void StartTimeMinutes_Loaded(object sender, RoutedEventArgs e)
        {
            List<int> StartMinutes = new List<int>();

            StartMinutes.Add(0);
            StartMinutes.Add(5);
            StartMinutes.Add(10);
            StartMinutes.Add(15);
            StartMinutes.Add(20);
            StartMinutes.Add(25);
            StartMinutes.Add(30);
            StartMinutes.Add(35);
            StartMinutes.Add(40);
            StartMinutes.Add(45);
            StartMinutes.Add(50);
            StartMinutes.Add(55);
            SMinute.ItemsSource = StartMinutes;
            SMinute.SelectedItem = addShiftViewModel.StartMinute;
        }

        private void EndHourSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.EndHour=Int32.Parse(EHour.SelectedItem.ToString());
        }

        private void EndTimeHour_Loaded(object sender, RoutedEventArgs e)
        {
            int SetHour;
            List<int> EndHours = new List<int>();

            EndHours.Add(00);
            EndHours.Add(01);
            EndHours.Add(02);
            EndHours.Add(03);
            EndHours.Add(04);
            EndHours.Add(05);
            EndHours.Add(06);
            EndHours.Add(07);
            EndHours.Add(08);
            EndHours.Add(09);
            EndHours.Add(10);
            EndHours.Add(11);
            EndHours.Add(12);
            EHour.ItemsSource = EndHours;

            // this is for converting from 24 time
            if (addShiftViewModel.EndHour > 12)
            {
                SetHour = addShiftViewModel.EndHour - 12;
            }
            else
            {
                SetHour = addShiftViewModel.EndHour;
            }

            EHour.SelectedItem = SetHour;
        }

        private void EndTimeMinutes_Loaded(object sender, RoutedEventArgs e)
        {
            List<int> EndMinutes = new List<int>();

            EndMinutes.Add(0);
            EndMinutes.Add(5);
            EndMinutes.Add(10);
            EndMinutes.Add(15);
            EndMinutes.Add(20);
            EndMinutes.Add(25);
            EndMinutes.Add(30);
            EndMinutes.Add(35);
            EndMinutes.Add(40);
            EndMinutes.Add(45);
            EndMinutes.Add(50);
            EndMinutes.Add(55);
            EMinute.ItemsSource = EndMinutes;
            EMinute.SelectedItem = addShiftViewModel.EndMinute;
        }

        private void EMinute_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.EndMinute =Int32.Parse(EMinute.SelectedItem.ToString());
        }

        private void StartAmOrPmLoaded(object sender, RoutedEventArgs e)
        {
            List<String> Meridian = new List<string>();

            Meridian.Add("AM");
            Meridian.Add("PM");

            SAMPM.ItemsSource = Meridian;
            SAMPM.SelectedItem = addShiftViewModel.StartTimeAmPM;
        }

        private void StartAmOrPmSet(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.StartTimeAmPM = SAMPM.SelectedItem.ToString();
        }

        private void EndAmOrPmLoaded(object sender, RoutedEventArgs e)
        {
            List<String> Meridian = new List<string>();

            Meridian.Add("AM");
            Meridian.Add("PM");

            EAMPM.ItemsSource = Meridian;
            EAMPM.SelectedItem = addShiftViewModel.EndTimeAmPm;
        }

        private void EndAmOrPmSet(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            addShiftViewModel.EndTimeAmPm = EAMPM.SelectedItem.ToString();
        }
        #endregion
    }
}