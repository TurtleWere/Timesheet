namespace Timesheet.Core.Models
{
    public class Statistic
    {
        public Statistic(){}

        public string StudentName { get; set; }
        public float HoursWas {  get; set; }
        public float HoursWasnt { get; set; }
        public float HoursForReason { get; set; }

        public float PercentWas { get; set; }
        public float PercentWasnt { get; set; }
        public float PercentForReason { get; set; }

    }
}
