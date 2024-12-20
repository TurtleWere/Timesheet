namespace Timesheet.Core.Models
{
    public class Statistic
    {
        public Statistic(string student_name, int hours_was, int hours_wasnt, int hours_forReason)
        {
            Student_name = student_name;
            Hours_was = hours_was;
            Hours_wasnt = hours_wasnt;
            Hours_forReason = hours_forReason;
        }

        public string Student_name { get; set; }
        public int Hours_was {  get; set; }
        public int Hours_wasnt { get; set; }
        public int Hours_forReason { get; set; }
    }
}
