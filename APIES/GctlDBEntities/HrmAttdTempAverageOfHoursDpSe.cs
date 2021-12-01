using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_TempAverageOfHours_Dp_Se")]
    public partial class HrmAttdTempAverageOfHoursDpSe
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [StringLength(50)]
        public string TotalTime { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalHours { get; set; }
        [Column("TotHrswith_WH", TypeName = "decimal(18, 2)")]
        public decimal? TotHrswithWh { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MonthWiseAvgHrs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
    }
}
