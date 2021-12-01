using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_CompanyWeekEnd1")]
    public partial class HrmAtdCompanyWeekEnd1
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyWeekEndCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Sat { get; set; }
        [Required]
        [StringLength(50)]
        public string Sun { get; set; }
        [Required]
        [StringLength(50)]
        public string Mon { get; set; }
        [Required]
        [StringLength(50)]
        public string Tue { get; set; }
        [Required]
        [StringLength(50)]
        public string Wed { get; set; }
        [Required]
        [StringLength(50)]
        public string Thu { get; set; }
        [Required]
        [StringLength(50)]
        public string Fri { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EffectiveDate { get; set; }
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
