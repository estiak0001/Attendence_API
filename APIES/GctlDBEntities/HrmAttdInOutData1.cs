using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_InOutData1")]
    public partial class HrmAttdInOutData1
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
        public DateTime InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OutTime { get; set; }
        [Required]
        [StringLength(50)]
        public string AttdDataType { get; set; }
        [Required]
        [StringLength(50)]
        public string FileName { get; set; }
    }
}
