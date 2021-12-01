using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_Section")]
    public partial class HrmDefSection
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string SectionCode { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(50)]
        public string SectionShortName { get; set; }
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
        [Required]
        [StringLength(100)]
        public string BanglaSection { get; set; }
        [Required]
        [StringLength(100)]
        public string BanglaShortName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
    }
}
