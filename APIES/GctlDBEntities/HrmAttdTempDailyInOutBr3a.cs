using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Temp_DailyInOut_Br_3A")]
    public partial class HrmAttdTempDailyInOutBr3a
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
        public string SectionName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(100)]
        public string LineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutTime { get; set; }
        [Column("SDIntime", TypeName = "datetime")]
        public DateTime? Sdintime { get; set; }
        [Column("SDOutTime", TypeName = "datetime")]
        public DateTime? SdoutTime { get; set; }
        [Column("OutTime_br", TypeName = "datetime")]
        public DateTime? OutTimeBr { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
        [Column("OTTimeBr")]
        [StringLength(30)]
        public string OttimeBr { get; set; }
        [Column("HMSIn24hc")]
        [StringLength(20)]
        public string Hmsin24hc { get; set; }
        [Column("HMIN12hc")]
        [StringLength(20)]
        public string Hmin12hc { get; set; }
        [Column("HMIN24hc")]
        [StringLength(20)]
        public string Hmin24hc { get; set; }
        [Column("HIn12hc")]
        [StringLength(20)]
        public string Hin12hc { get; set; }
        [Column("MIn12hc")]
        [StringLength(20)]
        public string Min12hc { get; set; }
        [Column("Mod_MIn12hc")]
        [StringLength(20)]
        public string ModMin12hc { get; set; }
        [Column("Mod_SIn12hc")]
        [StringLength(20)]
        public string ModSin12hc { get; set; }
        [Column("AMPM")]
        [StringLength(20)]
        public string Ampm { get; set; }
        [StringLength(50)]
        public string AttendanceTypeCode { get; set; }
    }
}
