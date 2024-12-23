namespace Timesheet.Core.Models
{
    public class Statistic
    {
        public Statistic(){}

        public string Student_name { get; set; }
        public int Hours_was {  get; set; }
        public int Hours_wasnt { get; set; }
        public int Hours_forReason { get; set; }

        public float precent_was { get; set; }
        public float precent_wasnt { get; set; }
        public float precent_forReason { get; set; }

    }
}
