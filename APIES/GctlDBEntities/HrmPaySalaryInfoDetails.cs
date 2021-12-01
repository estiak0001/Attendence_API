using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_SalaryInfoDetails")]
    public partial class HrmPaySalaryInfoDetails
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal SalaryInfoDetailsCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SalaryInfoDetailsId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeCode { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Gross { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Basic { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Housing { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Medical { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Food { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Stamp { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Bonus { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Conveyance { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
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
