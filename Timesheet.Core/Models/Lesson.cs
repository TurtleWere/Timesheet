
using System.Xml.Linq;

namespace Timesheet.Core.Models
{
    /// <summary>
    /// Пара(урок)
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Номер дня в году
        /// </summary>
        public int Day_id { get; set; }
        /// <summary>
        /// Номер пары в дне
        /// </summary>
        public int Lesson_id { get; set; }
        /// <summary>
        /// Название предмета
        /// </summary>
        public string Name { get; set; }

        public Lesson()
        {
        }

        //public Lesson(int day_id, int lesson_id, string name)
        //{
        //    Day_id = day_id;
        //    Lesson_id = lesson_id;
        //    Name = name;
        //}


    }
}
