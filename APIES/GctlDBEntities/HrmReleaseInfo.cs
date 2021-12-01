using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ReleaseInfo")]
    public partial class HrmReleaseInfo
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal ReleaseCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ReleaseId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal FinalPayment { get; set; }
        [Required]
        [StringLength(1)]
        public string IsPaid { get; set; }
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
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
