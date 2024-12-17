
namespace Timesheet.Core.Models
{
    public class Attendance
    {
        public string Group_id { get; set; }
        public Guid Student_id { get; set; }
        public int Day_id { get; set; }
        public int Lesson_num { get; set; } /// <summary>
        /// номер пары по счету
        /// </summary>
        public Status Status { get; set; }
        public string Description { get; set; } = string.Empty;

    }
    public enum Status{
        Присутсвует = 0,
        Отсутсвует = 1,
        По_уважительной = 2,
    }
}
