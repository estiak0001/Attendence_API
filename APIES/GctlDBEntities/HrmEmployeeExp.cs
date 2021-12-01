using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeExp")]
    public partial class HrmEmployeeExp
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmpExpID")]
        [StringLength(50)]
        public string EmpExpId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [Column("CompanyNameID")]
        [StringLength(100)]
        public string CompanyNameId { get; set; }
        [Required]
        public string BusinessType { get; set; }
        [Required]
        public string Address { get; set; }
        [Column("DepartmentID")]
        [StringLength(50)]
        public string DepartmentId { get; set; }
        [Required]
        [Column("DesignationID")]
        [StringLength(100)]
        public string DesignationId { get; set; }
        [Required]
        public string Responsibilities { get; set; }
        [Required]
        [Column("JobNatureID")]
        [StringLength(100)]
        public string JobNatureId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ToDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Salary { get; set; }
        [Required]
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
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
