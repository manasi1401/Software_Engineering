using Scheduleator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class UserManagerViewModel : INotifyPropertyChanged
    {
        #region Member Variables
        private ObservableCollection<Employee> _EmployeeCollection;
        private ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
        private Employee _CurrentSelectedEmployee = new Employee();
        private bool _IsNoneZeroUserCount;
        private string _UserName;
        private string _ID;
        private string _PIN;
        private bool _IsManager;
        private bool _IsCook ;
        private bool _IsDishwasher;
        private bool _IsCashier;
        private bool _IsWaiter;
        private int _HourlyWage;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructor
        public UserManagerViewModel(List<Employee> registeredEmployees)
        {
            if (registeredEmployees != null)
            {
                RegisteredEmployees = new ObservableCollection<Employee>(registeredEmployees);
            }
            else
            {
                RegisteredEmployees = new ObservableCollection<Employee>();
            }

            if(_EmployeeCollection.Count == 0)
            {
                IsNoneZeroUserCount = false;
            }
            else
            {
                CurrentSelectedEmployee = _EmployeeCollection.FirstOrDefault<Employee>();
                UserName = CurrentSelectedEmployee.UserName;
                PIN = CurrentSelectedEmployee.PIN;
                ID = CurrentSelectedEmployee.ID.ToString();
                IsManager = CurrentSelectedEmployee.IsManager;
                IsCook = CurrentSelectedEmployee.IsCook;
                IsDishwasher = CurrentSelectedEmployee.IsDishwasher;
                IsCashier = CurrentSelectedEmployee.IsCashier;
                IsWaiter = CurrentSelectedEmployee.IsWaiter;
                HourlyWage = CurrentSelectedEmployee.HourlyWage;
                IsNoneZeroUserCount = true;
            }
        }
        #endregion

        #region Properties
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string PIN
        {
            get { return _PIN; }
            set
            {
                _PIN = value;
                OnPropertyChanged(nameof(PIN));
            }
        }

        public ObservableCollection<Employee> RegisteredEmployees
        {
            get { return _EmployeeCollection; }
            set
            {
                _EmployeeCollection = value;
                OnPropertyChanged(nameof(RegisteredEmployees));
            }
        }

        public Employee CurrentSelectedEmployee
        {
            get { return _CurrentSelectedEmployee; }
            set
            {
                _CurrentSelectedEmployee = value;
                OnPropertyChanged(nameof(CurrentSelectedEmployee));
            }
        }

        public bool IsNoneZeroUserCount
        {
            get { return _IsNoneZeroUserCount; }
            set
            {
                _IsNoneZeroUserCount = value;
                OnPropertyChanged(nameof(IsNoneZeroUserCount));
            }
        }

        public bool IsManager {
            get => _IsManager;
            set { _IsManager = value;
                OnPropertyChanged(nameof(IsManager));
            }
        }
        public bool IsCook
        {
            get => _IsCook;
            set { _IsCook = value;
                OnPropertyChanged(nameof(IsCook));
            }
        }
        public bool IsDishwasher
        {
            get => _IsDishwasher;
            set { _IsDishwasher = value;
                OnPropertyChanged(nameof(IsDishwasher));
            }
        }
        public bool IsCashier {
            get => _IsCashier;
            set {
                _IsCashier = value;
                OnPropertyChanged(nameof(IsCashier));
            }
        }
        public bool IsWaiter {
            get => _IsWaiter;
            set { _IsWaiter = value;
                OnPropertyChanged(nameof(IsWaiter));
            }

        }

        public int HourlyWage {
            get => _HourlyWage;
            set
            {
                _HourlyWage = value;
                OnPropertyChanged(nameof(HourlyWage));

            }
        }
        #endregion

        #region Public Methods
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
              
            }
        }

        public void DeleteEmployee()
        {
            Employee employeeToRemove = RegisteredEmployees.ToList<Employee>().Where(s => s.ID == CurrentSelectedEmployee.ID).FirstOrDefault<Employee>();
            RegisteredEmployees.Remove(employeeToRemove);
            OnPropertyChanged(nameof(RegisteredEmployees));
        }

        public void ChangeSelectedEmployee()
        {
            if(CurrentSelectedEmployee != null)
            {
                UserName = CurrentSelectedEmployee.UserName;
                PIN = CurrentSelectedEmployee.PIN;
                ID = CurrentSelectedEmployee.ID.ToString();
                IsManager = CurrentSelectedEmployee.IsManager;
                IsCook = CurrentSelectedEmployee.IsCook;
                IsDishwasher = CurrentSelectedEmployee.IsDishwasher;
                IsCashier = CurrentSelectedEmployee.IsCashier;
                HourlyWage = CurrentSelectedEmployee.HourlyWage;
                IsWaiter = CurrentSelectedEmployee.IsWaiter;
            }
            else
            {
                CurrentSelectedEmployee = RegisteredEmployees.FirstOrDefault<Employee>();
            }
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
