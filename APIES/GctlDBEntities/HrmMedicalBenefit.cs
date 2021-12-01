using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Medical_Benefit")]
    public partial class HrmMedicalBenefit
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("MedicalBenefitID")]
        [StringLength(50)]
        public string MedicalBenefitId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("Issue_Date", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Required]
        [StringLength(200)]
        public string Purpose { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Salary { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal MemberNo { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Limit { get; set; }
        [Column("Payment_Amount", TypeName = "numeric(18, 2)")]
        public decimal PaymentAmount { get; set; }
        public string Remarks { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "datetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
