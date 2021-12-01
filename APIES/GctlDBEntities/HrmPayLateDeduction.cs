using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_LateDeduction")]
    public partial class HrmPayLateDeduction
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal LateDeductionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string LateDeductionId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Days { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal PercentageValue { get; set; }
        [Required]
        [StringLength(50)]
        public string PayHeadNameId { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(250)]
        public string Remark { get; set; }
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
