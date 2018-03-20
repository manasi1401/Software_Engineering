using Scheduleator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeUI
{
    /// <summary>
    /// Interaction logic for EmployeeProfile.xaml
    /// </summary>
   
    public partial class EmployeeProfile : Window
    {
        private string _Uname;
        private long _UserId;
        private int _HourlyWage;
        public EmployeeProfile(Employee employee)
        {
            InitializeComponent();
            this.DataContext = this;
            UserId = employee.ID;
            Uname = employee.UserName;
            HourlyWage = employee.HourlyWage;
        }

        public string Uname { get => _Uname; set => _Uname = value; }
        public long UserId { get => _UserId; set => _UserId = value; }
        public int HourlyWage { get => _HourlyWage; set => _HourlyWage = value; }

        private void Close_WindowButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
