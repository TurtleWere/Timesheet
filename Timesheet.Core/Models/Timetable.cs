

namespace Timesheet.Core.Models
{
    public class Timetable
    {
        public Timetable(string id, Day[] days)
        {
            Id = id;
            Days = days;
        }

        /// <summary>
        /// Id группы 
        /// </summary>
        public string Id { get; set; } 
        public Day[] Days { get; set; }

    }
}
