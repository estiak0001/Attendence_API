using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Sales_Def_PaymentTerms")]
    public partial class SalesDefPaymentTerms
    {
        [Column("TC")]
        public int Tc { get; set; }
        [StringLength(50)]
        public string PaymentTermsId { get; set; }
        [StringLength(50)]
        public string PaymentTermsName { get; set; }
        [StringLength(50)]
        public string Percentise { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public int? CreditDays { get; set; }
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
