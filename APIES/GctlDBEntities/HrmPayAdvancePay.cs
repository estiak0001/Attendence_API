using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_AdvancePay")]
    public partial class HrmPayAdvancePay
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AdvancePayCode { get; set; }
        [Required]
        [StringLength(50)]
        public string AdvancePayId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string AdvanceAdjustStatus { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal MonthlyDeduction { get; set; }
        [Required]
        [StringLength(50)]
        public string SalaryMonth { get; set; }
        [Required]
        [StringLength(50)]
        public string SalaryYear { get; set; }
        [Required]
        [StringLength(50)]
        public string NoOfPaymentInstallment { get; set; }
        [Required]
        [StringLength(50)]
        public string PayHeadNameId { get; set; }
        [Required]
        [StringLength(500)]
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
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
