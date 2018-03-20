using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Scheduleator
{
    public partial class MainMenuWindow : Window
    {
        private ConsoleViewModel _ConsoleViewModel;

        public MainMenuWindow()
        {
            InitializeComponent();
            _ConsoleViewModel = new ConsoleViewModel();
            _ConsoleViewModel.InitializeViewModelData();
        }

        private void btnShiftManagementWindow_Click(object sender, RoutedEventArgs e)
        {
            Shiftviewer shiftViewer = new Shiftviewer();
            shiftViewer.Show();
            this.Close();
        }

        private void btnUserManagementWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            UserManagementWindow userManagementWindow = new UserManagementWindow();
            userManagementWindow.Show();
            this.Close();
        }

        private void btnPrintScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath;
            _ConsoleViewModel.InitializeViewModelData();
            _ConsoleViewModel.GenerateSchedule();
            _ConsoleViewModel.SaveScheduleProgress();
            filePath = _ConsoleViewModel.PrintSchedule();
            MessageBox.Show("\r\nSchedule Printed!\r\nYou can find the file at: " + filePath + "\r\n");
        }

        private void btnLogoutSession_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("\r\nDo you want to exit?\r\n","Exiting..", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
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