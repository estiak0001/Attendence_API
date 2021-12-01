using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Temp_TotalOT3")]
    public partial class HrmAttdTempTotalOt3
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        public TimeSpan TotalOt { get; set; }
        [Column("OTInMinutes", TypeName = "numeric(18, 2)")]
        public decimal? OtinMinutes { get; set; }
        [Column("OTInMinutes_ss", TypeName = "numeric(18, 2)")]
        public decimal? OtinMinutesSs { get; set; }
    }
}
