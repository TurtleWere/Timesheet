using Timesheet.Core.Models;
namespace Timesheet.Core.Interfaces
{
    public interface IAttendanceRepository
    {
        IEnumerable<Statistic> GetAttendances(Guid student_id);
        bool CreateAttendance(Attendance attendance);

        void UpdateAttendance(Attendance attendance);

        public void CreateTable();
    }
}
