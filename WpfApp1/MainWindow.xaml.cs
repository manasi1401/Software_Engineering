using EmployeeUI;
using System.Collections.Generic;
using System.Windows;

namespace Scheduleator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _MainWindowViewModel;
        private ConsoleViewModel consoleViewModel = new ConsoleViewModel();

        public MainWindow()
        {
            _MainWindowViewModel = new MainWindowViewModel();
            InitializeComponent();
            this.DataContext = _MainWindowViewModel;
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            consoleViewModel.InitializeViewModelData();
            List<Employee> Employees = new List<Employee>();
            Employees = consoleViewModel.EmployeeList();

            if (!_MainWindowViewModel.ManagerEnabled &&
               _MainWindowViewModel.UserName == "admin" && _MainWindowViewModel.Password == "x123xadmin")
            {
                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                mainMenuWindow.Show();
                this.Close();
                return;
            }

            if (!_MainWindowViewModel.EmployeeEnabled && Employees.Exists(x=>x.UserName == _MainWindowViewModel.UserName))
            {
                Employee found = Employees.Find(x => x.UserName == _MainWindowViewModel.UserName);

                if(found.PIN == _MainWindowViewModel.Password && found.IsManager ==false)
                {
                    //Window needs to be changed to employee UI
                    EmployeeView employeeView = new EmployeeView(found);
                    employeeView.Show();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    return;
                }
            }
            if (!_MainWindowViewModel.ManagerEnabled &&
               Employees.Exists(x => x.UserName == _MainWindowViewModel.UserName))
            {
                Employee ManagerFound = Employees.Find(x => x.UserName == _MainWindowViewModel.UserName);
                if(ManagerFound.PIN ==_MainWindowViewModel.Password && ManagerFound.IsManager ==true)
                {
                    MainMenuWindow mainMenuWindow = new MainMenuWindow();
                    mainMenuWindow.Show();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    return;
                }
                
            }
            
            
                MessageBox.Show("\r\nWrong Login Username/ Password (Case Sensitivity)\r\n" + "\nCheck User Preference");
            return;


        }

        private void btnEmployeeLoginSelection_Click(object sender, RoutedEventArgs e)
        {
            _MainWindowViewModel.EmployeeEnabled = false;
            _MainWindowViewModel.ManagerEnabled = true;
        }

        private void btnManagerLoginSelection_Click(object sender, RoutedEventArgs e)
        {
            _MainWindowViewModel.ManagerEnabled = false;
            _MainWindowViewModel.EmployeeEnabled = true;
        }
    }
}
