using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("RMG_TermsCondition")]
    public partial class RmgTermsCondition
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [StringLength(50)]
        public string TermsConditionId { get; set; }
        [StringLength(1000)]
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
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("CompanyID")]
        [StringLength(50)]
        public string CompanyId { get; set; }
    }
}
