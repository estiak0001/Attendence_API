using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Separation")]
    public partial class HrmSeparation
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal SeparationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SeparationId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SeparationDate { get; set; }
        [Required]
        [StringLength(100)]
        public string SeparationTypeId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal FinalPayment { get; set; }
        [Required]
        [StringLength(1)]
        public string IsPaid { get; set; }
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
