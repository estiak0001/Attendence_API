using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_Rules")]
    public partial class HrmPayRules
    {
        [Required]
        [StringLength(50)]
        public string RuleName { get; set; }
        [Required]
        [Column("SHName")]
        [StringLength(50)]
        public string Shname { get; set; }
        [StringLength(50)]
        public string RuleDefinition { get; set; }
        [StringLength(50)]
        public string StateStatus { get; set; }
        [StringLength(50)]
        public string StateRemarks { get; set; }
    }
}
