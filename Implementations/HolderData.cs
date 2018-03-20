using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduleator
{
    public class HolderData
    {
        #region Member Variables
        private List<Employee> _RegisteredEmployees = new List<Employee>();
        private List<Shift> _CreatedShifts = new List<Shift>();
        #endregion

        #region Properties
        public List<Employee> RegisteredEmployees
        {
            get { return _RegisteredEmployees; }
            set { _RegisteredEmployees = value; }
        }

        public List<Shift> CreatedShifts
        {
            get { return _CreatedShifts; }
            set { _CreatedShifts = value; }
        }
        #endregion
    }
}
