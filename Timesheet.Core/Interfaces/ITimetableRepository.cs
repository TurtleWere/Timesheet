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
        IEnumerable<Timetable> GetTimetable(string id);
        Timetable UpdateTimetable(string id, int day_id, int lesson_id);

    }
}
