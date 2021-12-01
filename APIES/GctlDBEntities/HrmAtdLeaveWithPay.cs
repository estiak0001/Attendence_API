using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_LeaveWithPay")]
    public partial class HrmAtdLeaveWithPay
    {
        [Column("autoId")]
        public int AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        [Column("fromDate", TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Column("toDate", TypeName = "datetime")]
        public DateTime ToDate { get; set; }
        [Column("hrsDays", TypeName = "decimal(5, 2)")]
        public decimal HrsDays { get; set; }
        [Required]
        [Column("remarks")]
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
    }
}
