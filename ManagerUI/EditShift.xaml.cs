using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Scheduleator
{
	
	public partial class EditShift : Window
	{
        ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
        EditShiftViewModel editShiftViewModel;

		public EditShift (Shift shift)
		{
			InitializeComponent ();
     
           editShiftViewModel = new EditShiftViewModel(shift);
            this.DataContext = editShiftViewModel;
		}

        private void SaveChange(object sender, RoutedEventArgs e)
        {
            _ConsoleViewModel.InitializeViewModelData();
            
            List<Shift> temp = _ConsoleViewModel.ShiftList();
            Shift found = temp.Find(x=>x.ShiftID.Equals(editShiftViewModel.Id));
            if(found != null)
            {
                found.DateOfShift = editShiftViewModel.Date;
                int year = editShiftViewModel.Date.Year;
                int month = editShiftViewModel.Date.Month;
                int day = editShiftViewModel.Date.Day;
                found.Coverage = editShiftViewModel.Coverage;
                found.EndTime = new DateTime(year, month, day, editShiftViewModel.EHour, editShiftViewModel.EMinute, 0);
                found.StartTime = new DateTime(year, month, day, editShiftViewModel.SHour, editShiftViewModel.SMinute, 0);
                found.WorkingEmployees = editShiftViewModel.WorkingEmployees;
                found.AvailableEmployees = editShiftViewModel.AvailableEmployee;
                found.NumberOfCashiers = editShiftViewModel.NumberOfCashiers;
                found.NumberOfCooks = editShiftViewModel.NumberOfCooks;
                found.NumberOfDiswashers = editShiftViewModel.NumberOfDiswashers;
                found.NumberOfManagers = editShiftViewModel.NumberOfManagers;
                found.NumberOfWaiters = editShiftViewModel.NumberOfWaiters;
            }
            int delete = temp.FindIndex(x => x.ShiftID.Equals(editShiftViewModel.Id));
            _ConsoleViewModel.DeleteFromShiftList(delete);
            _ConsoleViewModel.AddShift(found);
            _ConsoleViewModel.SaveScheduleProgress();
            Shiftviewer shiftviewer = new Shiftviewer();
            shiftviewer.Show();
            this.Close();

        }

        private void DiscardChange(object sender, RoutedEventArgs e)
        {
            Shiftviewer shiftviewer = new Shiftviewer();
            shiftviewer.Show();
            this.Close();
        }

        private void DeleteShift(object sender, RoutedEventArgs e)
        {
            _ConsoleViewModel.InitializeViewModelData();

            List<Shift> temp = _ConsoleViewModel.ShiftList();
            int delete = temp.FindIndex(x => x.ShiftID.Equals(editShiftViewModel.Id));
            if(delete != -1)
            _ConsoleViewModel.DeleteFromShiftList(delete);
            _ConsoleViewModel.SaveScheduleProgress();
            Shiftviewer shiftviewer = new Shiftviewer();
            shiftviewer.Show();
            this.Close();
        }

        private void StartHour_Loaded(object sender, RoutedEventArgs e)
        {
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
            StartHour.ItemsSource = StartHours;
            int SetHour;
            if (editShiftViewModel.SHour > 12)
                SetHour = editShiftViewModel.SHour - 12;
            else
                SetHour = editShiftViewModel.SHour;
            StartHour.SelectedItem = SetHour;
        }

        private void HourChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            editShiftViewModel.SHour=Int32.Parse(StartHour.SelectedItem.ToString());
        }

        private void StartMinute_Loaded(object sender, RoutedEventArgs e)
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
            StartMin.ItemsSource = StartMinutes;
            StartMin.SelectedItem = editShiftViewModel.SMinute;

        }

        private void StartMinutesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            editShiftViewModel.SMinute = Int32.Parse(StartMin.SelectedItem.ToString());
        }

        private void AmOrPmLoaded(object sender, RoutedEventArgs e)
        {
            List<String> Meridian = new List<string>();
            Meridian.Add("AM");
            Meridian.Add("PM");
            AMPM.ItemsSource = Meridian;
            AMPM.SelectedItem = editShiftViewModel.StartAmOrPm;
        }

        private void AmOrPmSet(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            editShiftViewModel.StartAmOrPm = AMPM.SelectedItem.ToString();
        }

        private void EHourChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            editShiftViewModel.EHour = Int32.Parse(EndHour.SelectedItem.ToString());
        }

        private void EndHour_Loaded(object sender, RoutedEventArgs e)
        {
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
            EndHour.ItemsSource = EndHours;
            int SetHour;
            if (editShiftViewModel.EHour > 12)
                SetHour = editShiftViewModel.EHour - 12;
            else
                SetHour = editShiftViewModel.EHour;
            EndHour.SelectedItem = SetHour;
           
        }

        private void EndMinute_Loaded(object sender, RoutedEventArgs e)
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
            EndMin.ItemsSource = EndMinutes;
            EndMin.SelectedItem = editShiftViewModel.EMinute;
        }

        private void EndMinutesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
          editShiftViewModel.EMinute= Int32.Parse(EndMin.SelectedItem.ToString());
        }

        private void EndAmOrPmLoaded(object sender, RoutedEventArgs e)
        {
            List<String> Meridian = new List<string>();
            Meridian.Add("AM");
            Meridian.Add("PM");
            EAMPM.ItemsSource = Meridian;
            EAMPM.SelectedItem = editShiftViewModel.EndAmOrPm;
        }

        private void EndAmOrPmSet(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            editShiftViewModel.EndAmOrPm = EAMPM.SelectedItem.ToString();

        }
    }
}
