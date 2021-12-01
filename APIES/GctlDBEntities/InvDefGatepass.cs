using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Inv_Def_Gatepass")]
    public partial class InvDefGatepass
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("Gatepass_NO")]
        [StringLength(50)]
        public string GatepassNo { get; set; }
        [StringLength(50)]
        public string GatePassType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        [StringLength(100)]
        public string VehicleRegNo { get; set; }
        [Column("InvoiceNO")]
        [StringLength(100)]
        public string InvoiceNo { get; set; }
        [StringLength(50)]
        public string ChallanNo { get; set; }
        [StringLength(50)]
        public string RepairStatus { get; set; }
        [StringLength(100)]
        public string Returned { get; set; }
        [StringLength(200)]
        public string AllowTo { get; set; }
        public string AllowAddress { get; set; }
        [StringLength(50)]
        public string AllowPhone { get; set; }
        [Column("allowNationalID")]
        [StringLength(100)]
        public string AllowNationalId { get; set; }
        [Column("Gate_Keeper")]
        [StringLength(100)]
        public string GateKeeper { get; set; }
        [StringLength(10)]
        public string SecurityInCharge { get; set; }
        [StringLength(100)]
        public string StoreOfficer { get; set; }
        [StringLength(50)]
        public string StoreOfficerPhone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
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
        [Column("CompanyID")]
        [StringLength(50)]
        public string CompanyId { get; set; }
        [Column("UserEmployeeID")]
        [StringLength(50)]
        public string UserEmployeeId { get; set; }
        [StringLength(50)]
        public string JobCardNo { get; set; }
        [StringLength(100)]
        public string ApproveStatus { get; set; }
        public string ApproveRemarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [Column("VehicleInChargeID")]
        [StringLength(50)]
        public string VehicleInChargeId { get; set; }
        [StringLength(100)]
        public string VehicleInChargePhone { get; set; }
    }
}
