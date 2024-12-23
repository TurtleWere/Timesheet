using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheet.Core.Models
{
    public class Statistic
    {
        public Statistic(){}

        [Column("StudentName")]
        public string StudentName { get; set; }
        [Column("HoursWas")]
        public float HoursWas {  get; set; }
        [Column("HoursWasnt")]
        public float HoursWasnt { get; set; }
        [Column("HoursForReason")]
        public float HoursForReason { get; set; }
        [Column("PercentWas")]
        public float PercentWas { get; set; }
        [Column("PercentWasnt")]
        public float PercentWasnt { get; set; }
        [Column("PercentForReason")]
        public float PercentForReason { get; set; }

    }
}
