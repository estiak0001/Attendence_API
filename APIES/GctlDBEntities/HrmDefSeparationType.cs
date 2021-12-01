using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_SeparationType")]
    public partial class HrmDefSeparationType
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal SeparationTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SeparationTypeId { get; set; }
        [Required]
        [StringLength(250)]
        public string SeparationType { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
