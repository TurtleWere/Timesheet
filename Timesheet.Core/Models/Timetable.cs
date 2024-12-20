

namespace Timesheet.Core.Models
{
    public class Timetable
    {
        public Timetable(string id, List<Lesson> lessons)
        {
            Id = id;
            Lessons = lessons;
        }


        /// <summary>
        /// Id группы 
        /// </summary>
        public string Id { get; set; } 
        public List<Lesson> Lessons { get; set; }

    }
}
