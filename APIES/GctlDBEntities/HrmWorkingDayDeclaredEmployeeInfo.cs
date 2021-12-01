using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_WorkingDayDeclaredEmployeeInfo")]
    public partial class HrmWorkingDayDeclaredEmployeeInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WorkingDayDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
    }
}
