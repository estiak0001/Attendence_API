using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("SALES_Def_BankInfo")]
    public partial class SalesDefBankInfo
    {
        public int BankCode { get; set; }
        [Required]
        [Column("BankID")]
        [StringLength(50)]
        public string BankId { get; set; }
        [StringLength(50)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
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
