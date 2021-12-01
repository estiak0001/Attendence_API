using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Temp_JobCard_2")]
    public partial class HrmAttdTempJobCard2
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
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutTime { get; set; }
        [Column("OutTime_br", TypeName = "datetime")]
        public DateTime? OutTimeBr { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
        [Column("OTTimeBr")]
        [StringLength(30)]
        public string OttimeBr { get; set; }
        [Column("OTTimeBr_Nu")]
        public int? OttimeBrNu { get; set; }
        [Column("OTTimeAct")]
        [StringLength(30)]
        public string OttimeAct { get; set; }
        [Column("OTTimeAct_Nu")]
        public int? OttimeActNu { get; set; }
        [Column("SDIntime", TypeName = "datetime")]
        public DateTime? Sdintime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConInTime { get; set; }
        [Column("SDOutTime", TypeName = "datetime")]
        public DateTime? SdoutTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AbsentTime { get; set; }
        [Column("OUTMOD")]
        [StringLength(20)]
        public string Outmod { get; set; }
        [Column("WH")]
        public int? Wh { get; set; }
    }
}
