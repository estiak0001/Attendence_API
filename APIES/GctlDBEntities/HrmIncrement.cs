using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Increment")]
    public partial class HrmIncrement
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [StringLength(50)]
        public string IncrementId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Year { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PreviousSalary { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal IncAmount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PresentSalary { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(500)]
        public string IncLetterNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IncLetterDate { get; set; }
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
        [StringLength(50)]
        public string IncType { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
    }
}
