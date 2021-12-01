using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_LeaveApplicationDays")]
    public partial class HrmLeaveApplicationDays
    {
        [Key]
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string LeaveAppEntryId { get; set; }
        [Column("days", TypeName = "datetime")]
        public DateTime Days { get; set; }
    }
}
