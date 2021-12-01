using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Suspension")]
    public partial class HrmSuspension
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal SuspensionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SuspensionId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SuspensionDate { get; set; }
        [Required]
        [StringLength(250)]
        public string Reason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DurationFrom { get; set; }
        [Required]
        [StringLength(1)]
        public string IsContinuing { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime To { get; set; }
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
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
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
