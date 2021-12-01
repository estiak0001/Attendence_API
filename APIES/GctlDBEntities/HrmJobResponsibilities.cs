using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Job_Responsibilities")]
    public partial class HrmJobResponsibilities
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("JobResponsibilitiesID")]
        [StringLength(50)]
        public string JobResponsibilitiesId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoiningDate { get; set; }
        [Required]
        [Column("ISSupervisor")]
        [StringLength(200)]
        public string Issupervisor { get; set; }
        [Required]
        [StringLength(200)]
        public string JobObjectives { get; set; }
        [Required]
        [StringLength(200)]
        public string KeyPerformanceAreas { get; set; }
        [Required]
        [StringLength(200)]
        public string Duties { get; set; }
        [Required]
        [StringLength(200)]
        public string ReportingTo { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime? Wef { get; set; }
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
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
