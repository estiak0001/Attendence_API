using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_Shift")]
    public partial class HrmAtdShift
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [StringLength(50)]
        public string ShiftCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ShiftName { get; set; }
        [Required]
        [StringLength(250)]
        public string ShiftShortName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ShiftStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ShiftEndTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AbsentTime { get; set; }
        [Column("WEF", TypeName = "datetime")]
        public DateTime Wef { get; set; }
        [Required]
        [StringLength(500)]
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
        [Column("ShiftTypeID")]
        [StringLength(50)]
        public string ShiftTypeId { get; set; }
    }
}
