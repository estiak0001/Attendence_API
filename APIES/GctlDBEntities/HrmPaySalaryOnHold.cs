using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_SalaryOnHold")]
    public partial class HrmPaySalaryOnHold
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal SalaryOnHoldCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SalaryOnHoldId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        public byte MonthNum { get; set; }
        public short SalaryYear { get; set; }
        [Required]
        [StringLength(500)]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
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
    }
}
