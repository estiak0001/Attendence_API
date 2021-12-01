using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_OvertimeSheet")]
    public partial class HrmPayTempOvertimeSheet
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? GrossSalary { get; set; }
        [Column("ActOT")]
        public int? ActOt { get; set; }
        [Column("OT_Amt", TypeName = "numeric(18, 2)")]
        public decimal? OtAmt { get; set; }
        [Column("TDay")]
        public int? Tday { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Tiffin { get; set; }
        public int? AllowDay { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? AllowAmt { get; set; }
        public int? Mobile { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Total { get; set; }
    }
}
