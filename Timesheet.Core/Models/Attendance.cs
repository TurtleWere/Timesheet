
namespace Timesheet.Core.Models
{
    public class Attendance
    {
        public string GroupId { get; set; }
        public Guid StudentId { get; set; }
        public int DayId { get; set; }
        /// <summary>
        /// номер пары по счету
        /// </summary>
        public int LessonNum { get; set; } 
        public Status Status { get; set; }
        public string Description { get; set; } = string.Empty;

    }
    public enum Status{
        Присутсвует = 0,
        Отсутсвует = 1,
        По_уважительной = 2,
    }
}
