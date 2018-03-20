using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduleator
{
    public interface IScheduleUser
    {
        string UserName { get; set; }
        bool IsManager { get; }
        long ID { get; set; }
        string PIN { get; set; }
    }
}