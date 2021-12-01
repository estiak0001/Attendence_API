using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_SendEmailEmployeeInfo")]
    public partial class HrmSendEmailEmployeeInfo
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("TrainingTitleID")]
        [StringLength(50)]
        public string TrainingTitleId { get; set; }
        [StringLength(100)]
        public string TrainingEmial { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrainingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrainingEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmissionDate { get; set; }
        [Column("ISMailSend")]
        [StringLength(50)]
        public string IsmailSend { get; set; }
        [Column("LDate", TypeName = "datetime")]
        public DateTime? Ldate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LIP")]
        [StringLength(150)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(250)]
        public string Lmac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Column("UserEmployeeID")]
        [StringLength(50)]
        public string UserEmployeeId { get; set; }
        [StringLength(50)]
        public string CompanyCode { get; set; }
    }
}
