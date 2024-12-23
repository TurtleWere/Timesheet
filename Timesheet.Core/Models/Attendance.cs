
namespace Timesheet.Core.Models
{
    public class Attendance
    {
        public Attendance(string groupId, Guid studentId, int dayId, int lessonId, Status status, string description)
        {
            GroupId = groupId;
            StudentId = studentId;
            DayId = dayId;
            LessonId = lessonId;
            Status = status;
            Description = description;
        }

        public string GroupId { get; set; }
        public Guid StudentId { get; set; }
        public int DayId { get; set; }
        /// <summary>
        /// номер пары по счету
        /// </summary>
        public int LessonId { get; set; } 
        public Status Status { get; set; }
        public string Description { get; set; } = string.Empty;

    }
    public enum Status
    {
        Present = 0,
        Absent = 1,
        Excused = 2,
    }
}
