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
    public class ShiftManagementViewModel : INotifyPropertyChanged
    {
        #region Constants
        private const int FORWARD_WEEK_DAYS = 7;
        private const int BACKWARD_WEEK_DAYS = -7;
        private const int INCREMENT_TO_MONDAY = 1;
        private const int INCREMENT_TO_TUESDAY = 2;
        private const int INCREMENT_TO_WEDNESDAY = 3;
        private const int INCREMENT_TO_THURSDAY = 4;
        private const int INCREMENT_TO_FRIDAY = 5;
        private const int INCREMENT_TO_SATURDAY = 6;
        #endregion

        #region Member Variables

        #region List View Content
        private ObservableCollection<Shift> _SundayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _MondayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _TuesdayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _WednesdayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _ThursdayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _FridayList = new ObservableCollection<Shift>();
        private ObservableCollection<Shift> _SaturdayList = new ObservableCollection<Shift>();
        #endregion

        #region List View Headers
        private string _SundayHeader;
        private string _MondayHeader;
        private string _TuesdayHeader;
        private string _WednesdayHeader;
        private string _ThursdayHeader;
        private string _FridayHeader;
        private string _SaturdayHeader;

        #endregion

        private DateTime StartDate;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructor
        public ShiftManagementViewModel(List<Shift> initialShiftList)
        {
            StartDate = DateTime.Today;
            ProcessNewWeekOfShifts(initialShiftList);
        }
        #endregion

        #region Properties

        #region List View Content
        public ObservableCollection<Shift> SundayList
        {
            get { return _SundayList; }
            set
            {
                _SundayList = value;
                OnPropertyChanged(nameof(SundayList));
            }
        }

        public ObservableCollection<Shift> MondayList
        {
            get { return _MondayList; }
            set
            {
                _MondayList = value;
                OnPropertyChanged(nameof(MondayList));
            }
        }

        public ObservableCollection<Shift> TuesdayList
        {
            get { return _TuesdayList; }
            set
            {
                _TuesdayList = value;
                OnPropertyChanged(nameof(TuesdayList));
            }
        }

        public ObservableCollection<Shift> WednesdayList
        {
            get { return _WednesdayList; }
            set
            {
                _WednesdayList = value;
                OnPropertyChanged(nameof(WednesdayList));
            }
        }

        public ObservableCollection<Shift> ThursdayList
        {
            get { return _ThursdayList; }
            set
            {
                _ThursdayList = value;
                OnPropertyChanged(nameof(ThursdayList));
            }
        }

        public ObservableCollection<Shift> FridayList
        {
            get { return _FridayList; }
            set
            {
                _FridayList = value;
                OnPropertyChanged(nameof(FridayList));
            }
        }

        public ObservableCollection<Shift> SaturdayList
        {
            get { return _SaturdayList; }
            set
            {
                _SaturdayList = value;
                OnPropertyChanged(nameof(SaturdayList));
            }
        }
        #endregion

        #region List View Headers

        public string SundayHeader
        {
            get { return _SundayHeader;}
            set
            {
                _SundayHeader = value;
                OnPropertyChanged(nameof(SundayHeader));
            }
        }

        public string MondayHeader
        {
            get { return _MondayHeader; }
            set
            {
                _MondayHeader = value;
                OnPropertyChanged(nameof(MondayHeader));
            }
        }

        public string TuesdayHeader
        {
            get { return _TuesdayHeader; }
            set
            {
                _TuesdayHeader = value;
                OnPropertyChanged(nameof(TuesdayHeader));
            }
        }

        public string WednesdayHeader
        {
            get { return _WednesdayHeader; }
            set
            {
                _WednesdayHeader = value;
                OnPropertyChanged(nameof(WednesdayHeader));
            }
        }

        public string ThursdayHeader
        {
            get { return _ThursdayHeader; }
            set
            {
                _ThursdayHeader = value;
                OnPropertyChanged(nameof(ThursdayHeader));
            }
        }

        public string FridayHeader
        {
            get { return _FridayHeader; }
            set
            {
                _FridayHeader = value;
                OnPropertyChanged(nameof(FridayHeader));
            }
        }

        public string SaturdayHeader
        {
            get { return _SaturdayHeader; }
            set
            {
                _SaturdayHeader = value;
                OnPropertyChanged(nameof(SaturdayHeader));
            }
        }
        #endregion

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

        public void ProcessLastWeekShifts(List<Shift> processShiftList)
        {
            StartDate = StartDate.AddDays(BACKWARD_WEEK_DAYS);

            ProcessNewWeekOfShifts(processShiftList);
        }

        public void ProcessNextWeekShifts(List<Shift> processShiftList)
        {
            StartDate = StartDate.AddDays(FORWARD_WEEK_DAYS);

            ProcessNewWeekOfShifts(processShiftList);
        }
        #endregion

        #region Private Methods
        private void RefreshDayOfWeekHeadersAndListViews()
        {
            SundayHeader = StartDate.ToShortDateString();
            MondayHeader = StartDate.AddDays(INCREMENT_TO_MONDAY).ToShortDateString();
            TuesdayHeader = StartDate.AddDays(INCREMENT_TO_TUESDAY).ToShortDateString();
            WednesdayHeader = StartDate.AddDays(INCREMENT_TO_WEDNESDAY).ToShortDateString();
            ThursdayHeader = StartDate.AddDays(INCREMENT_TO_THURSDAY).ToShortDateString();
            FridayHeader = StartDate.AddDays(INCREMENT_TO_FRIDAY).ToShortDateString();
            SaturdayHeader = StartDate.AddDays(INCREMENT_TO_SATURDAY).ToShortDateString();

            SundayList.Clear();
            MondayList.Clear();
            TuesdayList.Clear();
            WednesdayList.Clear();
            ThursdayList.Clear();
            FridayList.Clear();
            SaturdayList.Clear();
        }

        private void ProcessNewWeekOfShifts(List<Shift> processShiftList)
        {
            RefreshDayOfWeekHeadersAndListViews();

            foreach (Shift shift in processShiftList)
            {
                if (shift.StartTime.Date == StartDate)
                {
                    SundayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_MONDAY))
                {
                    MondayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_TUESDAY))
                {
                    TuesdayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_WEDNESDAY))
                {
                    WednesdayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_THURSDAY))
                {
                    ThursdayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_FRIDAY))
                {
                    FridayList.Add(shift);
                }
                else if (shift.StartTime.Date == StartDate.AddDays(INCREMENT_TO_SATURDAY))
                {
                    SaturdayList.Add(shift);
                }
            }
        }
        #endregion

    }
}
