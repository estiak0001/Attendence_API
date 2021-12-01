using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Temp_JobCard_3")]
    public partial class HrmTempJobCard3
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
        [Column("SDIntime", TypeName = "datetime")]
        public DateTime? Sdintime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConInTime { get; set; }
        [Column("SDOutTime", TypeName = "datetime")]
        public DateTime? SdoutTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AbsentTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MinTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaxTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AccDate { get; set; }
    }
}
