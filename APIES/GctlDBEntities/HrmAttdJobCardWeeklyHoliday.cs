using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_JobCard_WeeklyHoliday")]
    public partial class HrmAttdJobCardWeeklyHoliday
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(30)]
        public string InTime { get; set; }
        [StringLength(30)]
        public string OutTime { get; set; }
        [StringLength(30)]
        public string Late { get; set; }
        [Column("OT")]
        [StringLength(30)]
        public string Ot { get; set; }
        [StringLength(10)]
        public string AttStatus { get; set; }
        [Column("OTTimeBr")]
        [StringLength(30)]
        public string OttimeBr { get; set; }
        [Column("OTTimeAct")]
        [StringLength(30)]
        public string OttimeAct { get; set; }
    }
}
