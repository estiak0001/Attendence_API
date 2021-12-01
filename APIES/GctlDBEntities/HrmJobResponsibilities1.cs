using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_JobResponsibilities")]
    public partial class HrmJobResponsibilities1
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal JobResponsibilitiesCode { get; set; }
        [Required]
        [StringLength(50)]
        public string JobResponsibilitiesId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(250)]
        public string CoWorker { get; set; }
        [Required]
        [StringLength(250)]
        public string JobObjective { get; set; }
        [Required]
        [StringLength(250)]
        public string KeyPerformanceAreas { get; set; }
        [Required]
        [StringLength(250)]
        public string Duties { get; set; }
        [Required]
        [StringLength(50)]
        public string SupervisorId { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(500)]
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
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
