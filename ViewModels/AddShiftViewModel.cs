using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Scheduleator
{
	public class AddShiftViewModel 
    {
        private DateTime _ShiftDate =DateTime.Today;
        private int _StartHour;
        private int _StartMinute;
        private int _EndHour;
        private int _EndMinute;
        private int _NumPeople;
        private string _StartTimeAmPM;
        private string _EndTimeAmPm;
        private int _NumberOfCooks;
        private int _NumberOfDiswashers;
        private int _NumberOfManagers;
        private int _NumberOfCashiers;
        private int _NumberOfWaiters;
        public AddShiftViewModel ()
		{
			
		}
        public DateTime ShiftDate { get => _ShiftDate; set => _ShiftDate = value; }
        public int StartHour
        {
            get => _StartHour;
            set
            {
                    _StartHour = value;
               if(StartTimeAmPM == "PM" && _StartHour != 12)
                    _StartHour = value + 12;
                if (StartTimeAmPM == "AM" && _StartHour == 12)
                    _StartHour = 0;
                //Error Check
                if (_StartHour == 24)
                {
                    _StartHour -= 1;
                    _StartHour = 59;
                }
            }
        }
        public int StartMinute { get => _StartMinute; set => _StartMinute = value; }
        public int EndHour
        {
            get => _EndHour;
            set
            {
                    _EndHour = value;
                 if(EndTimeAmPm=="PM" && _EndHour != 12)
                    _EndHour = value + 12;
                if (EndTimeAmPm == "AM" && _EndHour == 12)
                    _EndHour = 0;
                //Error Check
                if (_EndHour == 24)
                {
                    _EndHour -= 1;
                    _EndMinute = 59;
                }
            }
        }
        public int EndMinute { get => _EndMinute; set => _EndMinute = value; }
        public int NumPeople { get => _NumPeople; set => _NumPeople = value; }
        public string StartTimeAmPM
        {
            get => _StartTimeAmPM;
            set
            {
                _StartTimeAmPM = value;
                if(value=="PM" && _StartHour <12)
                {
                    _StartHour += 12;
                }
                if(value== "AM" && _StartHour >12)
                {
                    _StartHour -= 12;
                }
                if (value == "AM" && _StartHour == 12)
                {
                    _StartHour =0;
                }
            }
        }
        public string EndTimeAmPm
        {
            get => _EndTimeAmPm;
            set
            {
                _EndTimeAmPm = value;
                if (value == "PM" && _EndHour < 12)
                {
                    _EndHour += 12;
                }
                if (value == "AM" && _EndHour > 12)
                {
                    _EndHour -= 12;
                }
                if (value == "AM" && _EndHour == 12)
                {
                    _EndHour =0;
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