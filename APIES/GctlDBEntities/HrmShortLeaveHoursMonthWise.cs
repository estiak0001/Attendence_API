using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ShortLeaveHoursMonthWise")]
    public partial class HrmShortLeaveHoursMonthWise
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonthStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MonthEndDate { get; set; }
        [StringLength(50)]
        public string TotalTime { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalHours { get; set; }
        [Column("IsSLTimeAdj")]
        public int? IsSltimeAdj { get; set; }
    }
}
