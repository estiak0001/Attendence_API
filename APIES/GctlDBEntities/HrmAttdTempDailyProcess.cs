using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Temp_DailyProcess")]
    public partial class HrmAttdTempDailyProcess
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
        [StringLength(11)]
        public string Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutTime { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
        [Column("SDIntime", TypeName = "datetime")]
        public DateTime? Sdintime { get; set; }
        [Column("SDOutTime", TypeName = "datetime")]
        public DateTime? SdoutTime { get; set; }
    }
}
