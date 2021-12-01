using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_TimeCalculation2_TBSC_F")]
    public partial class HrmAttdTimeCalculation2TbscF
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        public TimeSpan TotalTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public TimeSpan SalaryTranTime { get; set; }
        [Column("StayInOffice_Hours", TypeName = "numeric(18, 2)")]
        public decimal StayInOfficeHours { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal SalaryHours { get; set; }
        [Column(TypeName = "numeric(18, 6)")]
        public decimal SalaryAmount { get; set; }
        [Column("OT")]
        public TimeSpan Ot { get; set; }
    }
}
