using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Core.Models;

namespace Timesheet.Core.Interfaces
{
    public interface ITimetableRepository
    {
        Timetable GetTimetable(string id);
        Timetable UpdateTimetable(string group_id, int day_id, int lesson_id);

    }
}
