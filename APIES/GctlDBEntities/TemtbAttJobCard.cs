using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temtb_Att_JobCard")]
    public partial class TemtbAttJobCard
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [StringLength(50)]
        public string MachineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Time { get; set; }
    }
}
