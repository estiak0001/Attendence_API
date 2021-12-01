using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeRecomdedTrainingInfo")]
    public partial class HrmEmployeeRecomdedTrainingInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("TrainingID")]
        [StringLength(50)]
        public string TrainingId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("TrainingTitleID")]
        [StringLength(50)]
        public string TrainingTitleId { get; set; }
        public string Reason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrainingFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrainingTo { get; set; }
        [StringLength(50)]
        public string RecommendedBy { get; set; }
        [StringLength(50)]
        public string ApprovalBy { get; set; }
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
