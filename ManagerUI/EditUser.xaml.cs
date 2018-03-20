using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Scheduleator
{
    public partial class EditUser : Window, INotifyPropertyChanged
    {
        #region Member Variables
        private string _UserName;
        private string _PIN;
        private string _ID;
        private int _HourlyWage;
        private ConsoleViewModel _ConsoleViewModel;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        #region Constructor
        public EditUser(ConsoleViewModel consoleViewModel)
        {
            this.DataContext = this;

            _ConsoleViewModel = consoleViewModel;

            InitializeComponent();
        }
        #endregion

        #region Properties
        public bool ManagerCanSave
        {
            get
            {
                if (UserName == string.Empty || PIN == string.Empty || ID == string.Empty)
                {
                    return false;
                }

                return true;
            }
        }

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged(nameof(UserName));
                OnPropertyChanged(nameof(ManagerCanSave));
            }
        }

        public string PIN
        {
            get { return _PIN; }
            set
            {
                _PIN = value;
                OnPropertyChanged(nameof(PIN));
                OnPropertyChanged(nameof(ManagerCanSave));
            }
        }

        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
                OnPropertyChanged(nameof(ManagerCanSave));
            }
        }

        public int HourlyWage {
            get => _HourlyWage;
            set { _HourlyWage = value;
                OnPropertyChanged(nameof(HourlyWage));
            }
    }
        #endregion

        private void btnSaveUserProgress_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.UserName = UserName;
            employee.PIN = PIN;
            employee.ID = Convert.ToInt64(ID);
            employee.HourlyWage = HourlyWage;
            _ConsoleViewModel.HolderData.RegisteredEmployees.Add(employee);
            _ConsoleViewModel.SaveScheduleProgress();
            this.Close();
        }

        private void btnCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

    }
}