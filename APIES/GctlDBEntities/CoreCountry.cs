using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_Country")]
    public partial class CoreCountry
    {
        public int CountryCode { get; set; }
        [Required]
        [Column("CountryID")]
        [StringLength(50)]
        public string CountryId { get; set; }
        [StringLength(50)]
        public string CountryName { get; set; }
        [Column("IOCCode")]
        [StringLength(10)]
        public string Ioccode { get; set; }
        [Column("ISOCode")]
        [StringLength(50)]
        public string Isocode { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LIP")]
        [StringLength(100)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(100)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
