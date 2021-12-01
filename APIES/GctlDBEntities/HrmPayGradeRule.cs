using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_GradeRule")]
    public partial class HrmPayGradeRule
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal GradeRuleCode { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeRuleId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PayHeadNameId { get; set; }
        [Required]
        [StringLength(50)]
        public string CalculationTypeId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PercentageOnCalType { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TakaOnCalType { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
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
