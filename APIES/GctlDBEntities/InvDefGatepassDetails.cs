using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Inv_Def_GatepassDetails")]
    public partial class InvDefGatepassDetails
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("Gatepass_NO")]
        [StringLength(50)]
        public string GatepassNo { get; set; }
        [Column("ItemID")]
        [StringLength(50)]
        public string ItemId { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        [Column("itemQuantity", TypeName = "decimal(18, 2)")]
        public decimal? ItemQuantity { get; set; }
        [Column("quantityUnit")]
        [StringLength(50)]
        public string QuantityUnit { get; set; }
        [StringLength(100)]
        public string Packing { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
        [Column("UseremployeeID")]
        [StringLength(50)]
        public string UseremployeeId { get; set; }
    }
}
