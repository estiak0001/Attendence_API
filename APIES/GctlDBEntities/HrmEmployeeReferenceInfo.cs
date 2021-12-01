using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeReferenceInfo")]
    public partial class HrmEmployeeReferenceInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [Column("EmpReferenceID")]
        [StringLength(50)]
        public string EmpReferenceId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(150)]
        public string ReferenceName { get; set; }
        [StringLength(300)]
        public string OrganizationName { get; set; }
        [StringLength(50)]
        public string Designation { get; set; }
        public string RefAddress { get; set; }
        [Column("RelationID")]
        [StringLength(50)]
        public string RelationId { get; set; }
        [StringLength(100)]
        public string MobileNumber { get; set; }
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        public string Fax { get; set; }
        [StringLength(300)]
        public string Email { get; set; }
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
