using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_LeaveApplicationEntry")]
    public partial class HrmLeaveApplicationEntry
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal LeaveAppEntryCode { get; set; }
        [Key]
        [StringLength(50)]
        public string LeaveAppEntryId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string LeaveTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "decimal(10, 1)")]
        public decimal NoOfDay { get; set; }
        [Required]
        [StringLength(1)]
        public string HalfDay { get; set; }
        [Required]
        [StringLength(1)]
        public string FirstOrSecondHalf { get; set; }
        [Required]
        [StringLength(1000)]
        public string Reason { get; set; }
        [Required]
        [StringLength(50)]
        public string BossEmpAutoId { get; set; }
        [Required]
        [Column("HOD")]
        [StringLength(50)]
        public string Hod { get; set; }
        [Required]
        [StringLength(50)]
        public string IsApproved { get; set; }
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
        [StringLength(250)]
        public string ConfirmationRemarks { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("HODApprovalStatus")]
        [StringLength(50)]
        public string HodapprovalStatus { get; set; }
        [Required]
        [Column("HODApprovalRemarks")]
        public string HodapprovalRemarks { get; set; }
        [Required]
        [Column("HRApprovalStatus")]
        [StringLength(50)]
        public string HrapprovalStatus { get; set; }
        [Required]
        [Column("HRApprovalRemarks")]
        public string HrapprovalRemarks { get; set; }
        [StringLength(50)]
        public string ApplyLeaveFormat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShortLeaveFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShortLeaveTo { get; set; }
        public TimeSpan? ShortLeaveTime { get; set; }
        [Required]
        [StringLength(50)]
        public string LeaveApplyProcess { get; set; }
    }
}
