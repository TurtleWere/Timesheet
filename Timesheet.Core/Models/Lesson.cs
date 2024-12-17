
namespace Timesheet.Core.Models
{
    public class Lesson
    {


        public string Name { get; set; }
        public int Lesson_id { get; set; }
        public int Day_id { get; set; }
        public Lesson(string name, int lesson_id, int day_id)
        {
            Name = name;
            Lesson_id = lesson_id;
            Day_id = day_id;
        }
    }
}
