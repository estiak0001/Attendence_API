using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_SalaryHead")]
    public partial class HrmPaySalaryHead
    {
        [Required]
        [Column("SHCode")]
        [StringLength(10)]
        public string Shcode { get; set; }
        [Column("SHName")]
        [StringLength(50)]
        public string Shname { get; set; }
        [Column("SHType")]
        [StringLength(20)]
        public string Shtype { get; set; }
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
