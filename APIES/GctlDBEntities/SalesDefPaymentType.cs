using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Sales_Def_PaymentType")]
    public partial class SalesDefPaymentType
    {
        [Column("TC")]
        public int Tc { get; set; }
        [Required]
        [Column("PaymentTypeID")]
        [StringLength(50)]
        public string PaymentTypeId { get; set; }
        [StringLength(50)]
        public string PaymentType { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
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
