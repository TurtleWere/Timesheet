
namespace Timesheet.Core.Models
{
    public class Class
    {


        public string Name { get; set; }
        public int Class_num { get; set; }
        public int Day_id { get; set; }
        public Class(string name, int class_num, int day_id)
        {
            Name = name;
            Class_num = class_num;
            Day_id = day_id;
        }
    }
}
