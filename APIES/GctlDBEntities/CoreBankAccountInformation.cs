using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_BankAccountInformation")]
    public partial class CoreBankAccountInformation
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("AccInfoID")]
        [StringLength(50)]
        public string AccInfoId { get; set; }
        [Required]
        [StringLength(250)]
        public string AccountName { get; set; }
        [Column("AccountNO")]
        [StringLength(250)]
        public string AccountNo { get; set; }
        [Column("BankID")]
        [StringLength(50)]
        public string BankId { get; set; }
        [Column("BranchID")]
        [StringLength(50)]
        public string BranchId { get; set; }
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
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
