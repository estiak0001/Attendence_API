using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Tem_AttdSummary")]
    public partial class TemAttdSummary
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
    }
}
