using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_SalaryInformation")]
    public partial class HrmPaySalaryInformation
    {
        [Required]
        [Column("SHCode")]
        [StringLength(10)]
        public string Shcode { get; set; }
        [Column("SHName")]
        [StringLength(30)]
        public string Shname { get; set; }
        [Column("SHAmount")]
        [StringLength(15)]
        public string Shamount { get; set; }
        [Column("SHType")]
        [StringLength(6)]
        public string Shtype { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(20)]
        public string EmployeeId { get; set; }
    }
}
