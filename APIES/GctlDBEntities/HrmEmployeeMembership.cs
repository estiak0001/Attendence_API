using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeMembership")]
    public partial class HrmEmployeeMembership
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpMembershipCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [Required]
        [StringLength(100)]
        public string Organization { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        [StringLength(100)]
        public string MemberId { get; set; }
        [Required]
        [StringLength(100)]
        public string Position { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime JoinDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expires { get; set; }
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
    }
}
