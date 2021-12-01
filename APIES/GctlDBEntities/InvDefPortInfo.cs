using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Inv_Def_PortInfo")]
    public partial class InvDefPortInfo
    {
        public int AutoId { get; set; }
        [StringLength(50)]
        public string PortId { get; set; }
        [StringLength(100)]
        public string PortName { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        [StringLength(50)]
        public string DeliveryMethodId { get; set; }
        public string PortAddress { get; set; }
        [Column("CountryID")]
        [StringLength(50)]
        public string CountryId { get; set; }
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
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string CompanyCode { get; set; }
    }
}
