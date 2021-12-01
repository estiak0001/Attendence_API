using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ManualTimeScheduleEntry")]
    public partial class HrmManualTimeScheduleEntry
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("MTS_ID")]
        [StringLength(50)]
        public string MtsId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string WorkingOrOffDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OfficeInTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OfficeOutTime { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("SessionEmployeeID")]
        [StringLength(50)]
        public string SessionEmployeeId { get; set; }
        [Column("RSS_ID")]
        [StringLength(50)]
        public string RssId { get; set; }
    }
}
