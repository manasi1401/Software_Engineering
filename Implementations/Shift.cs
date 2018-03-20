using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduleator
{
    public class Shift
    {
        #region Member Variables
        private DateTime _StartTime; //start of shift
        private DateTime _EndTime; //end of shift
        private DateTime _DateOfShift; //day of the week / we can have a specific date
        private List<Employee> _WorkingEmployees = new List<Employee>();
        private List<Employee> _AvailableEmployee = new List<Employee>();
        private int _Coverage; //number of people required for that shift
        private long _ShiftID = 0;
        private int _NumberOfCooks;
        private int _NumberOfDiswashers;
        private int _NumberOfManagers;
        private int _NumberOfCashiers;
        private int _NumberOfWaiters;
        #endregion

        #region Constructor
        public Shift()
        {

        }
        #endregion

        #region Properties
        public List<Employee> AvailableEmployees
        {
            get { return _AvailableEmployee; }
            set { _AvailableEmployee = value; }
        }

        public List<Employee> WorkingEmployees
        {
            get { return _WorkingEmployees; }
            set { _WorkingEmployees = value; }
        }

        public long ShiftID
        {
            get { return _ShiftID; }
            set { _ShiftID = value; }
        }

        public string StartTimeFormatted
        {
            get { return _StartTime.ToShortTimeString(); }
        }

        public string CurrentDateString
        {
            get { return _StartTime.ToShortDateString(); }
        }

        public string EndTimeFormatted
        {
            get { return _EndTime.ToShortTimeString(); }
        }

        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        public DateTime DateOfShift
        {
            get { return _DateOfShift; }
            set { _DateOfShift = value; }
        }

        public TimeSpan NumberOfHours
        {
            get { return _EndTime.Subtract(_StartTime); }
        }

        public int Coverage
        {
            get { return NumberOfCashiers+NumberOfCooks+NumberOfDiswashers+NumberOfManagers+NumberOfWaiters; }
            set { _Coverage = value; }
        }

        public int NumberOfCooks
        {
            get { return _NumberOfCooks; }
            set { _NumberOfCooks = value; }
        }

        public int NumberOfDiswashers
        {
            get { return _NumberOfDiswashers; }
            set {_NumberOfDiswashers = value;}
        }

        public int NumberOfManagers
        {
            get { return _NumberOfManagers; }
            set { _NumberOfManagers = value; }
        }

        public int NumberOfCashiers
        {
            get { return _NumberOfCashiers; }
            set { _NumberOfCashiers = value; }
        }

        public int NumberOfWaiters
        {
            get { return _NumberOfWaiters; }
            set { _NumberOfWaiters = value; }
        }
        #endregion

        #region Public Methods
        public void AddWorkingEmployee(Employee employee)
        {
            _WorkingEmployees.Add(employee);
        }

        public void AddAvailableEmployee(Employee employee)
        {
            _AvailableEmployee.Add(employee);
        }
        #endregion
    }
}
