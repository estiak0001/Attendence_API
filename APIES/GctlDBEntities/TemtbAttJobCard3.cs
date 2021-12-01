using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temtb_Att_JobCard_3")]
    public partial class TemtbAttJobCard3
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [StringLength(100)]
        public string DesignationName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string LineName { get; set; }
        [StringLength(11)]
        public string Date { get; set; }
        [StringLength(30)]
        public string InTime { get; set; }
        [StringLength(30)]
        public string OutTime { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
        public int? MachineId { get; set; }
    }
}
