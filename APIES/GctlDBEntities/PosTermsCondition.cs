using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Pos_TermsCondition")]
    public partial class PosTermsCondition
    {
        [Column("TC")]
        public int Tc { get; set; }
        [StringLength(50)]
        public string TermsConditionId { get; set; }
        public string TermsConditionName { get; set; }
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
        [StringLength(50)]
        public string TermUsed { get; set; }
    }
}
