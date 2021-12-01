using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_OvertimeSheet2")]
    public partial class HrmPayTempOvertimeSheet2
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
        [StringLength(50)]
        public string String1 { get; set; }
        [StringLength(50)]
        public string String2 { get; set; }
        public int? Int1 { get; set; }
        public int? Int2 { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Numeric1 { get; set; }
    }
}
