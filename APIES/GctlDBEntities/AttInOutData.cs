using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    public partial class AttInOutData
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutTime { get; set; }
        [StringLength(50)]
        public string ShiftCode { get; set; }
        [Column("ISDDEmpty")]
        [StringLength(50)]
        public string Isddempty { get; set; }
        [Column("ND_MD_MinDT", TypeName = "datetime")]
        public DateTime? NdMdMinDt { get; set; }
        [Column("ND_DD_MinDT", TypeName = "datetime")]
        public DateTime? NdDdMinDt { get; set; }
    }
}
