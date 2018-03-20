using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduleator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _Password;
        private string _UserName;
        private bool _EmployeeEnabled = false;
        private bool _ManagerEnabled = true;
    public event PropertyChangedEventHandler PropertyChanged;

        public bool EmployeeEnabled
        {
            get { return _EmployeeEnabled; }
            set
            {
                _EmployeeEnabled = value;
                OnPropertyChanged(nameof(EmployeeEnabled));
            }
        }

        public bool ManagerEnabled
        {
            get { return _ManagerEnabled; }
            set
            {
                _ManagerEnabled = value;
                OnPropertyChanged(nameof(ManagerEnabled));
            }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }


        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
