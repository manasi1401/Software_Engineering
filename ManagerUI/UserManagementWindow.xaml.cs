using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ViewModels;

namespace Scheduleator
{
    public partial class UserManagementWindow : Window 
    {
        #region Member Variables
        private UserManagerViewModel _UserManagerViewModel;
        private ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
        #endregion

        #region Constructor
        public UserManagementWindow()
        {
            InitializeComponent();
            
            _ConsoleViewModel.InitializeViewModelData();
            _UserManagerViewModel = new UserManagerViewModel(_ConsoleViewModel.HolderData.RegisteredEmployees);

            this.DataContext = _UserManagerViewModel;
        }
        #endregion

        #region Private Methods

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            EditUser editUser = new EditUser(_ConsoleViewModel);
            _ConsoleViewModel.InitializeViewModelData();
            editUser.ShowDialog();
            _ConsoleViewModel.InitializeViewModelData();
            _UserManagerViewModel.RegisteredEmployees = new ObservableCollection<Employee>(_ConsoleViewModel.HolderData.RegisteredEmployees);
        }

        private void btnSaveButton_Click(object sender, RoutedEventArgs e)
        {
            _ConsoleViewModel.HolderData.RegisteredEmployees = _UserManagerViewModel.RegisteredEmployees.ToList<Employee>();
            Employee itemToRemove = _ConsoleViewModel.HolderData.RegisteredEmployees.Where(s => s.ID == _UserManagerViewModel.CurrentSelectedEmployee.ID).First<Employee>();
            _ConsoleViewModel.HolderData.RegisteredEmployees.Remove(itemToRemove);
            itemToRemove.ID = Convert.ToInt64(_UserManagerViewModel.ID);
            itemToRemove.IsCashier = _UserManagerViewModel.IsCashier;
            itemToRemove.IsManager = _UserManagerViewModel.IsManager;
            itemToRemove.IsCook = _UserManagerViewModel.IsCook;
            itemToRemove.PIN = _UserManagerViewModel.PIN;
            itemToRemove.IsWaiter = _UserManagerViewModel.IsWaiter;
            itemToRemove.IsDishwasher = _UserManagerViewModel.IsDishwasher;
            itemToRemove.UserName = _UserManagerViewModel.UserName;
            itemToRemove.HourlyWage = _UserManagerViewModel.HourlyWage;
            _ConsoleViewModel.HolderData.RegisteredEmployees.Add(itemToRemove);
            _ConsoleViewModel.SaveScheduleProgress();
            _ConsoleViewModel.InitializeViewModelData();
            _UserManagerViewModel.RegisteredEmployees = new ObservableCollection<Employee>(_ConsoleViewModel.HolderData.RegisteredEmployees);

        }

        private void btnDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Employee itemToRemove = _ConsoleViewModel.HolderData.RegisteredEmployees.Where(s => s.ID == _UserManagerViewModel.CurrentSelectedEmployee.ID).First<Employee>();
            _ConsoleViewModel.HolderData.RegisteredEmployees.Remove(itemToRemove);
            
            _ConsoleViewModel.SaveScheduleProgress();
            _ConsoleViewModel.InitializeViewModelData();
            _UserManagerViewModel.RegisteredEmployees = new ObservableCollection<Employee>(_ConsoleViewModel.HolderData.RegisteredEmployees);
        }

        private void btnCancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();
            mainMenuWindow.Show();
            this.Close();
        }

        private void btnManageAvalability_Click(object sender, RoutedEventArgs e)
        {
            ManageShifts manageShiftsWindow = new ManageShifts(_UserManagerViewModel.CurrentSelectedEmployee);
            manageShiftsWindow.ShowDialog();
        }
        #endregion

        private void lstEmployeeViewer_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _UserManagerViewModel.ChangeSelectedEmployee();
        }

        private void txtEmployeePIN_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}