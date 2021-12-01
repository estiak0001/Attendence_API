using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temtb_Att_JobCard_2")]
    public partial class TemtbAttJobCard2
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MinTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaxTime { get; set; }
        [StringLength(50)]
        public string MachineId { get; set; }
    }
}
