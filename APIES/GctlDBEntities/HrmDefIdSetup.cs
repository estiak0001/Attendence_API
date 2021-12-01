using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_IdSetup")]
    public partial class HrmDefIdSetup
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string IdSetupCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SetupNameCode { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        [Required]
        [Column("numberingMethod")]
        [StringLength(50)]
        public string NumberingMethod { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Length { get; set; }
        [Column("startingNumber", TypeName = "numeric(18, 0)")]
        public decimal StartingNumber { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Increment { get; set; }
        [Column("resetDuration", TypeName = "numeric(18, 0)")]
        public decimal ResetDuration { get; set; }
        [Required]
        [Column("resetDurationType_Code")]
        [StringLength(50)]
        public string ResetDurationTypeCode { get; set; }
        [Required]
        [Column("prefix")]
        [StringLength(20)]
        public string Prefix { get; set; }
        [Required]
        [Column("suffix")]
        [StringLength(20)]
        public string Suffix { get; set; }
        [Required]
        [StringLength(1)]
        public string ZeroPadding { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(100)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(150)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
