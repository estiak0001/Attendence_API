using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_Bonus3")]
    public partial class HrmPayTempBonus3
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? GrossSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Bonus { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
    }
}
