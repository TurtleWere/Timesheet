using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Core.Models
{
    internal class Class
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
