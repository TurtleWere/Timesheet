
namespace Timesheet.Core.Models
{
    /// <summary>
    /// Пара(урок)
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Название предмета
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Номер пары в дне
        /// </summary>
        public int Lesson_id { get; set; }
        /// <summary>
        /// Номер дня в году
        /// </summary>
        public int Day_id { get; set; }
        public Lesson(string name, int lesson_id, int day_id)
        {
            Name = name;
            Lesson_id = lesson_id;
            Day_id = day_id;
        }
    }
}
