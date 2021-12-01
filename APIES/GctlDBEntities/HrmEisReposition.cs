using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EIS_Reposition")]
    public partial class HrmEisReposition
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [StringLength(50)]
        public string RepositionId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [StringLength(50)]
        public string Year { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(500)]
        public string RefLetterNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RefLetterDate { get; set; }
        [Required]
        [StringLength(500)]
        public string Remark { get; set; }
        [Required]
        [StringLength(10)]
        public string PreCompanyCode2 { get; set; }
        [Required]
        [StringLength(50)]
        public string PreBranchCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PreDivisionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PreDepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PreSectionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PreLineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PreDesignationCode { get; set; }
        [StringLength(50)]
        public string PreLocationCode { get; set; }
        [Required]
        [StringLength(10)]
        public string CurrCompanyCode2 { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrBranchCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrDivisionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrDepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrSectionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrLineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrDesignationCode { get; set; }
        [StringLength(50)]
        public string CurrLocationCode { get; set; }
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
