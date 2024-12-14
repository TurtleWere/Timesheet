using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Core.Models
{
    internal class Attendance
    {
        public string Group_id { get; set; }
        public Guid Student_id { get; set; }
        public int Day_id { get; set; }
        public int Class_num { get; set; }
        public string Status { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}
