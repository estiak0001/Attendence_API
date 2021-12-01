using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_CompanyLeaveSetup")]
    public partial class HrmAtdCompanyLeaveSetup
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal CompLeaveSetupCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CompLeaveSetupId { get; set; }
        [Required]
        [StringLength(50)]
        public string LeaveTypeId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal NoOfDay { get; set; }
        [Required]
        [StringLength(4)]
        public string Year { get; set; }
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
