using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_Bonus")]
    public partial class HrmPayTempBonus
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(100)]
        public string LineName { get; set; }
        [StringLength(100)]
        public string DesignationName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [StringLength(50)]
        public string LineCode { get; set; }
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [StringLength(10)]
        public string JoiningDate { get; set; }
        [StringLength(50)]
        public string GradeName { get; set; }
        [StringLength(50)]
        public string EmpType { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? GrossSalary { get; set; }
        [Column("T_Month")]
        public int? TMonth { get; set; }
        [Column("percentage", TypeName = "numeric(18, 2)")]
        public decimal? Percentage { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
    }
}
