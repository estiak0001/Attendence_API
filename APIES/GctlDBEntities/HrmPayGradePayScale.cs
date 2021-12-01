using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_GradePayScale")]
    public partial class HrmPayGradePayScale
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal GradePayScaleCode { get; set; }
        [Required]
        [StringLength(50)]
        public string GradePayScaleId { get; set; }
        [Required]
        [StringLength(50)]
        public string ScaleType { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeNameId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal GradeAmount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal GraIncAmountPerYear { get; set; }
        [Required]
        [StringLength(10)]
        public string MaxUpto { get; set; }
        [Required]
        [Column("YM")]
        [StringLength(100)]
        public string Ym { get; set; }
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
