using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_LeaveType")]
    public partial class HrmAtdLeaveType
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal LeaveTypeCode { get; set; }
        [Key]
        [StringLength(50)]
        public string LeaveTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string ShortName { get; set; }
        [Required]
        [StringLength(250)]
        public string RulePolicy { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal NoOfDay { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal For { get; set; }
        [Required]
        [Column("YMWD")]
        [StringLength(100)]
        public string Ymwd { get; set; }
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
    }
}
