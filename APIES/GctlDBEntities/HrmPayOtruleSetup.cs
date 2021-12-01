using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_OTRuleSetup")]
    public partial class HrmPayOtruleSetup
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal OvertimeRuleCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OvertimeRuleId { get; set; }
        [Column("OTMaxPerDay")]
        public int OtmaxPerDay { get; set; }
        [Required]
        [StringLength(50)]
        public string CalculationTypeId { get; set; }
        public int MultiplyWith { get; set; }
        [Column("OTMaxPerMonth")]
        public int OtmaxPerMonth { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }
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
