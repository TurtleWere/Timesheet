using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Core.Models;

namespace Timesheet.Core.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents(string group_id);
        Guid CreateStudent(string group_id, string name);
        Guid DeleteStudent(Guid id);
        Student UpdateStudent(Guid id, string group_id, string name);
        public void CreateTable();
    }
}