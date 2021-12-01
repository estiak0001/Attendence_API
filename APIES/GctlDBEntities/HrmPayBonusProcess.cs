using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_BonusProcess")]
    public partial class HrmPayBonusProcess
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal BonusProcessCode { get; set; }
        [Required]
        [StringLength(50)]
        public string BonusProcessId { get; set; }
        [Required]
        [StringLength(50)]
        public string BonusTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CountUptoDate { get; set; }
        [Required]
        [StringLength(1)]
        public string IsActive { get; set; }
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
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
