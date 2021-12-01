using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_Designation")]
    public partial class HrmDefDesignation
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [StringLength(100)]
        public string DesignationName { get; set; }
        [StringLength(50)]
        public string DesignationShortName { get; set; }
        [StringLength(50)]
        public string GradeCode { get; set; }
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
        public string BanglaDesignation { get; set; }
        [Required]
        [StringLength(100)]
        public string BanglaShortName { get; set; }
        [StringLength(50)]
        public string StepNoId { get; set; }
    }
}
