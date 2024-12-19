

using Timesheet.Core.Models;

namespace Timesheet.Core.Interfaces
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendances()
        
    }
}
