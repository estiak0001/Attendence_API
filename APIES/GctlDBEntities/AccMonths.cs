using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Acc_Months")]
    public partial class AccMonths
    {
        [Column("Month_Num")]
        public short MonthNum { get; set; }
        [Required]
        [Column("Month_Name")]
        [StringLength(12)]
        public string MonthName { get; set; }
        [Required]
        [Column("Month_Short")]
        [StringLength(3)]
        public string MonthShort { get; set; }
    }
}
