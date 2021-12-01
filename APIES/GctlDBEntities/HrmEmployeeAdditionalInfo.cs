using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeAdditionalInfo")]
    public partial class HrmEmployeeAdditionalInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(200)]
        public string PassportNo { get; set; }
        [Required]
        public string PassportPlaceOfIssue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PassportIssueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PassportExpiryDate { get; set; }
        [Required]
        [Column("SalaryBankID")]
        [StringLength(50)]
        public string SalaryBankId { get; set; }
        [Required]
        [Column("SalaryBranchID")]
        [StringLength(50)]
        public string SalaryBranchId { get; set; }
        [Required]
        public string BranchAddres { get; set; }
        [Required]
        [Column("BankACName")]
        [StringLength(300)]
        public string BankAcname { get; set; }
        [Required]
        [Column("BankAcNO")]
        [StringLength(200)]
        public string BankAcNo { get; set; }
        [Required]
        [StringLength(200)]
        public string AtmCardNo { get; set; }
        [Required]
        [StringLength(200)]
        public string LicenseNo { get; set; }
        [Required]
        [StringLength(200)]
        public string LicenseType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseIssueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseExpireDate { get; set; }
        [Required]
        [StringLength(300)]
        public string SymbolOfVehicleClass { get; set; }
        [Required]
        public string LicensePlaceOfIssue { get; set; }
        [Required]
        [Column("WorkPermitNO")]
        [StringLength(100)]
        public string WorkPermitNo { get; set; }
        [Required]
        [StringLength(200)]
        public string WorkPermitType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WpEffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WpExpireDate { get; set; }
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
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
