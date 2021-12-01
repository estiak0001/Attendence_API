using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("RMG_Prod_Def_Inv_SubItem2")]
    public partial class RmgProdDefInvSubItem2
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [Column("SubItem2ID")]
        [StringLength(50)]
        public string SubItem2Id { get; set; }
        [StringLength(250)]
        public string SubItem2Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [Column("MainItemID")]
        [StringLength(50)]
        public string MainItemId { get; set; }
        [Column("SubItemID")]
        [StringLength(50)]
        public string SubItemId { get; set; }
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
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
    }
}
