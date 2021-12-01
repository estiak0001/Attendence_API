using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("RMG_Prod_Def_NegativeFormat")]
    public partial class RmgProdDefNegativeFormat
    {
        [Column("TC")]
        public int Tc { get; set; }
        [Required]
        [StringLength(50)]
        public string DecimalPlaces { get; set; }
        [StringLength(50)]
        public string NegativeFormat { get; set; }
    }
}
