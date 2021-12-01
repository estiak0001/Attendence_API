using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_TimeCalculation_ByEmp2")]
    public partial class HrmAttdTimeCalculationByEmp2
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime In { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Out { get; set; }
        public TimeSpan? TotalHours { get; set; }
    }
}
