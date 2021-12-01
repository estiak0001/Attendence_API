using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_Promotion")]
    public partial class HrmPayPromotion
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal PromotionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PromotionId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string OldCompanyCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldBranchCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldDivisionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldDepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldSectionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldLineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldEmpTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldDesignationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string OldsupervisorAutoId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Required]
        [StringLength(50)]
        public string BranchCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DivisionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SectionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string LineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [Required]
        [Column("supervisorAutoId")]
        [StringLength(50)]
        public string SupervisorAutoId { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(250)]
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
    }
}
