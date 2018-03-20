using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Scheduleator
{
    public class EditShiftViewModel
    {
        private DateTime _Date;
        private long _id;
        private int _SHour;
        private int _SMinute;
        private int _EHour;
        private int _EMinute;
        private string _StartAmOrPm;
        private string _EndAmOrPm;
        private int _NumberOfCooks;
        private int _NumberOfDiswashers;
        private int _NumberOfManagers;
        private int _NumberOfCashiers;
        private int _NumberOfWaiters;
        private int _Coverage; //number of people required for that shift
        private List<Employee> _WorkingEmployees = new List<Employee>();
        private List<Employee> _AvailableEmployee = new List<Employee>();

        public EditShiftViewModel(Shift shift)
        {
            _Date = shift.DateOfShift;
            _id = shift.ShiftID;
            _SHour = shift.StartTime.Hour;
            _SMinute = shift.StartTime.Minute;
            _EHour = shift.EndTime.Hour;
            _EMinute = shift.EndTime.Minute;
            _Coverage = shift.Coverage;
            _WorkingEmployees = shift.WorkingEmployees;
            _AvailableEmployee = shift.AvailableEmployees;
            _NumberOfCooks = shift.NumberOfCooks;
            _NumberOfDiswashers = shift.NumberOfDiswashers;
            _NumberOfManagers = shift.NumberOfManagers;
            _NumberOfWaiters = shift.NumberOfWaiters;
            _NumberOfCashiers = shift.NumberOfCashiers;

            if (SHour >= 12)
                StartAmOrPm = "PM";
            else
                StartAmOrPm = "AM";
            if (EHour >= 12)
                EndAmOrPm = "PM";
            else
                EndAmOrPm = "AM";
        }

        public DateTime Date { get => _Date; set => _Date = value; }
        public long Id { get => _id; set => _id = value; }
        public int SHour
        {
            get => _SHour;
            set
            {
                    _SHour = value;
                if(StartAmOrPm== "PM" && _SHour !=12)
                    _SHour = value + 12;
                if (StartAmOrPm == "AM" && _SHour == 12)
                    _SHour = 0;
                //Error Check
                if(_SHour==24)
                {
                    _SHour -= 1;
                    _SMinute = 59;
                }
            }
        }
        public int SMinute { get => _SMinute; set => _SMinute = value; }
        public int EHour
        {
            get => _EHour;
            set
            {
             
                    _EHour = value;
                if (EndAmOrPm == "PM" && _EHour != 12)
                    _EHour = value + 12;
                if (EndAmOrPm == "AM" && _EHour == 12)
                    _EHour = 0;
                //Error Check
                if(_EHour== 24 )
                {
                    _EHour -= 1;
                    _EMinute = 59;
                }
            }
        }
        public int EMinute { get => _EMinute; set => _EMinute = value; }
        public int Coverage { get => _Coverage; set => _Coverage = value; }
        public List<Employee> WorkingEmployees { get => _WorkingEmployees; set => _WorkingEmployees = value; }
        public List<Employee> AvailableEmployee { get => _AvailableEmployee; set => _AvailableEmployee = value; }
        public string StartAmOrPm
        {
            get => _StartAmOrPm;
            set
            {
                _StartAmOrPm = value;
                if (value == "PM" && _SHour < 12)
                {
                    _SHour += 12;
                }
                if (value == "AM" && _SHour > 12)
                {
                    _SHour -= 12;
                }
                if (value == "AM" && _SHour == 12)
                {
                    _SHour= 0;
                }
            }
        }
        public string EndAmOrPm
        {
            get => _EndAmOrPm;
            set
            {
                _EndAmOrPm = value;
                if (value == "PM" && _EHour < 12)
                {
                    _EHour += 12;
                }
                if (value == "AM" && _EHour > 12)
                {
                    _EHour -= 12;
                }
                if (value == "AM" && _EHour == 12)
                {
                    _EHour = 0;
                }
            }
        }

        public int NumberOfCooks { get => _NumberOfCooks; set => _NumberOfCooks = value; }
        public int NumberOfDiswashers { get => _NumberOfDiswashers; set => _NumberOfDiswashers = value; }
        public int NumberOfManagers { get => _NumberOfManagers; set => _NumberOfManagers = value; }
        public int NumberOfCashiers { get => _NumberOfCashiers; set => _NumberOfCashiers = value; }
        public int NumberOfWaiters { get => _NumberOfWaiters; set => _NumberOfWaiters = value; }
    }
}