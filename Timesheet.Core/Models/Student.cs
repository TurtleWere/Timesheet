using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.Core.Models
{
    internal class Student
    {

        public Guid Id { get; }
        public string Name { get; }
        public string Group_id { get; }

        public Student(Guid id, string name, string group_id)
        {
            Id = id;
            Name = name;
            Group_id = group_id;
        }

    }
}
