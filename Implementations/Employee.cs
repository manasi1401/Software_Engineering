using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduleator
{
    public class Employee : IScheduleUser
    {
        #region Member Variables
        private DateTime _StartTime;
        private DateTime _EndTime;
        private long EmployeeID;
        private string _UserName = string.Empty;
        private string _PIN;
        private int _HourlyWage;
        private bool _IsManager = false;
        private bool _IsCook = false;
        private bool _IsDishwasher = false;
        private bool _IsCashier = false;
        private bool _IsWaiter = false;
        #endregion

        #region Properties
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        
        public DateTime StartTime
        {
            get { return _StartTime; }
        }

        public long ID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        public string PIN
        {
            get { return _PIN; }
            set { _PIN = value; }
        }

        public DateTime EndTime
        {
            get { return _EndTime; }
        }

        public bool IsManager
        {
            get { return _IsManager;}
            set { _IsManager = value; }
        }

        public bool IsCook {
            get { return _IsCook; }
            set { _IsCook = value; }
        }
        public bool IsDishwasher {
            get { return _IsDishwasher; }
            set { _IsDishwasher = value; }
        }
        public bool IsCashier {
            get { return _IsCashier; }
            set { _IsCashier = value; }
        }
        public bool IsWaiter
        {
            get { return _IsWaiter; }
            set { _IsWaiter = value; }
        }

        public int HourlyWage {
            get => _HourlyWage;
            set { _HourlyWage = value; }
        }
        #endregion
    }
}
