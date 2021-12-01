using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeMonthlyMovementInfo")]
    public partial class HrmEmployeeMonthlyMovementInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("MMPID")]
        [StringLength(50)]
        public string Mmpid { get; set; }
        [Column("MMPDate", TypeName = "datetime")]
        public DateTime? Mmpdate { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string MainCompanyCode { get; set; }
        [StringLength(50)]
        public string BranchCode { get; set; }
        [StringLength(50)]
        public string DivisionCode { get; set; }
        [Column("MonthID")]
        [StringLength(50)]
        public string MonthId { get; set; }
        [Column("DestinationID")]
        [StringLength(50)]
        public string DestinationId { get; set; }
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
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }
    }
}
