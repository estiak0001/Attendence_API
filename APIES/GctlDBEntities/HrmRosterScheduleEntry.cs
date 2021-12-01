using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_RosterScheduleEntry")]
    public partial class HrmRosterScheduleEntry
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Key]
        [StringLength(50)]
        public string RosterScheduleId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string ShiftCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Weekend { get; set; }
        [Required]
        [StringLength(500)]
        public string Remark { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("EmployeeID_SAO")]
        [StringLength(50)]
        public string EmployeeIdSao { get; set; }
    }
}
