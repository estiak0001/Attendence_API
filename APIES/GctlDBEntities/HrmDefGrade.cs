using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_Grade")]
    public partial class HrmDefGrade
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeCode { get; set; }
        [StringLength(100)]
        public string GradeName { get; set; }
        [StringLength(50)]
        public string GradeShortName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? FromGrossSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? ToGrossSalary { get; set; }
        [StringLength(50)]
        public string EmpTypeCode { get; set; }
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
