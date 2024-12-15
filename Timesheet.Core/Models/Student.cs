
namespace Timesheet.Core.Models
{
    public class Student
    {


        public Guid Id  { get; set; }
        public string Name { get; set;}
        public string Group_id { get; set;}

        public Student() { }
        public Student(Guid id, string name, string group_id)
        {
            Id = id;
            Name = name;
            Group_id = group_id;
        }

    }
}
