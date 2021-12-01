using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeIdConfiguration")]
    public partial class HrmEmployeeIdConfiguration
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeIdConfiguration_Code")]
        [StringLength(50)]
        public string EmployeeIdConfigurationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeIdConfiguration { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [Column("numberingMethod")]
        [StringLength(10)]
        public string NumberingMethod { get; set; }
        [Column("startingNumber", TypeName = "numeric(18, 0)")]
        public decimal StartingNumber { get; set; }
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
        [Column("padding")]
        [StringLength(20)]
        public string Padding { get; set; }
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
        [Required]
        [StringLength(50)]
        public string SetupNameCode { get; set; }
    }
}
