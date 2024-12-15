using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Core.Models
{
    public class Day
    {
        public int Id { get; set;  }
        public string Group_id { get; set; }
        public List<Class> Classes { get; set;}

    }
}
