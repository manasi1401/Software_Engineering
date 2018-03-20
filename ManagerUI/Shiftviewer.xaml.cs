using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using ViewModels;

namespace Scheduleator
{

    public partial class Shiftviewer : Window
    {
        ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
        ShiftManagementViewModel _ShiftManagermentViewModel;
        
        public Shiftviewer()
        {
            InitializeComponent();

            List<Shift> initialShiftList;

            _ConsoleViewModel.InitializeViewModelData();
            initialShiftList = _ConsoleViewModel.ShiftList();

            _ShiftManagermentViewModel = new ShiftManagementViewModel(initialShiftList);

            this.DataContext = _ShiftManagermentViewModel;
        }

        private void btnAddShift_Click(object sender, RoutedEventArgs e)
        {
            AddShift _addShift;
            
            _addShift = new AddShift();
            _addShift.ShowDialog();
            this.Close();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            List<Shift> lastWeekList;

            _ConsoleViewModel.InitializeViewModelData();
            lastWeekList = _ConsoleViewModel.ShiftList();
            _ShiftManagermentViewModel.ProcessLastWeekShifts(lastWeekList);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            List<Shift> nextWeekList;

            _ConsoleViewModel.InitializeViewModelData();
            nextWeekList = _ConsoleViewModel.ShiftList();
            _ShiftManagermentViewModel.ProcessNextWeekShifts(nextWeekList);
        }

        private void ShiftClicked(object sender, SelectionChangedEventArgs e)
        {
            Shift currentEditingShift;
            EditShift editShiftWindow;

            currentEditingShift = (Shift)e.AddedItems[0];
            editShiftWindow = new EditShift(currentEditingShift);
            editShiftWindow.ShowDialog();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();
            mainMenuWindow.Show();
            this.Close();
        }
    }

}
