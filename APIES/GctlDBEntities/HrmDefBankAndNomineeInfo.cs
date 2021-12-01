using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_BankAndNomineeInfo")]
    public partial class HrmDefBankAndNomineeInfo
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string BankAndNomineeId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [Column("BankID")]
        [StringLength(250)]
        public string BankId { get; set; }
        [Required]
        [Column("BankBranchID")]
        [StringLength(250)]
        public string BankBranchId { get; set; }
        [Required]
        [StringLength(100)]
        public string BankAccountName { get; set; }
        [Required]
        [StringLength(100)]
        public string BankAccountNo { get; set; }
        [Required]
        [Column("ATMCardNo")]
        [StringLength(100)]
        public string AtmcardNo { get; set; }
        [Required]
        [StringLength(100)]
        public string NomineeName { get; set; }
        [Required]
        [StringLength(100)]
        public string Relation { get; set; }
        [Required]
        [StringLength(100)]
        public string PresentAddress { get; set; }
        [Required]
        [Column("ParmanentAddress ")]
        [StringLength(100)]
        public string ParmanentAddress { get; set; }
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
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("EmployeeID2")]
        [StringLength(50)]
        public string EmployeeId2 { get; set; }
    }
}
