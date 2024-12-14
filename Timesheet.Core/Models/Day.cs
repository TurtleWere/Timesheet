using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Core.Models
{
    internal class Day
    {
        public int Id { get;  }
        public string Group_id { get; }
        public List<Class> classes { get; }

    }
}
