using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeMedicalInfo")]
    public partial class HrmEmployeeMedicalInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpMedicalInfoCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Height { get; set; }
        [Required]
        [StringLength(50)]
        public string Weight { get; set; }
        [Required]
        [StringLength(100)]
        public string HealthCard { get; set; }
        [Required]
        [StringLength(250)]
        public string Disease { get; set; }
        [Required]
        [StringLength(250)]
        public string Allergies { get; set; }
        [Required]
        [StringLength(250)]
        public string Operation { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal LimitAnount { get; set; }
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
        [Required]
        [StringLength(50)]
        public string HeightUnit { get; set; }
        [Required]
        [StringLength(50)]
        public string WeightUnit { get; set; }
    }
}
