using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Inv_Def_CompanyFor")]
    public partial class InvDefCompanyFor
    {
        [Column("TC")]
        public int Tc { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyForId { get; set; }
        [StringLength(50)]
        public string CompanyForName { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LIP")]
        [StringLength(100)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(100)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
