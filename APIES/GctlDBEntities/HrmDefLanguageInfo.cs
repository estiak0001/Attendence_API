using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_LanguageInfo")]
    public partial class HrmDefLanguageInfo
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal LanguageInfoCode { get; set; }
        [Required]
        [StringLength(50)]
        public string LanguageInfoId { get; set; }
        [Required]
        [StringLength(50)]
        public string LanguageInfo { get; set; }
        [Required]
        [StringLength(50)]
        public string ShortName { get; set; }
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
