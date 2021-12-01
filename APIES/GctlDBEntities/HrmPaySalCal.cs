using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_SalCal")]
    public partial class HrmPaySalCal
    {
        [StringLength(50)]
        public string HeadName { get; set; }
        [StringLength(50)]
        public string RuleString { get; set; }
        [StringLength(20)]
        public string RuleName { get; set; }
        [Column("EmployeeID")]
        [StringLength(20)]
        public string EmployeeId { get; set; }
    }
}
