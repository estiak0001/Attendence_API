using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ReAppointment")]
    public partial class HrmReAppointment
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal ReAppointmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ReAppointmentId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReAppointmentDate { get; set; }
        [Required]
        [StringLength(250)]
        public string Reason { get; set; }
        [Required]
        [StringLength(50)]
        public string RecommendedBy { get; set; }
        [Required]
        [StringLength(50)]
        public string ApprovedBy { get; set; }
        [Required]
        [StringLength(250)]
        public string Verdict { get; set; }
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
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
