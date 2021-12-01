using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Sales_Def_BankBranchInfo")]
    public partial class SalesDefBankBranchInfo
    {
        [Column("TC")]
        public int Tc { get; set; }
        [Required]
        [Column("BankBranchID")]
        [StringLength(50)]
        public string BankBranchId { get; set; }
        [StringLength(50)]
        public string BankBranchName { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        [Column("BankID")]
        [StringLength(50)]
        public string BankId { get; set; }
        [Column("SWIFTCode")]
        [StringLength(50)]
        public string Swiftcode { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LIP")]
        [StringLength(150)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(250)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
