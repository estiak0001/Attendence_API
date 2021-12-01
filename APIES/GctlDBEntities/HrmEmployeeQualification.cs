using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeQualification")]
    public partial class HrmEmployeeQualification
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmpQualificationID")]
        [StringLength(50)]
        public string EmpQualificationId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string CourseCode { get; set; }
        [StringLength(50)]
        public string CourseTitleCode { get; set; }
        [StringLength(50)]
        public string InstitueCode { get; set; }
        public string Instituteaddress { get; set; }
        [StringLength(200)]
        public string ResultDivision { get; set; }
        [StringLength(50)]
        public string YearofPasssing { get; set; }
        [StringLength(50)]
        public string Dueration { get; set; }
        [StringLength(50)]
        public string DuratioinType { get; set; }
        public string Achievment { get; set; }
        public string Remarks { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "datetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
