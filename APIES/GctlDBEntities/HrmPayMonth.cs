using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_PAY_Month")]
    public partial class HrmPayMonth
    {
        public byte MonthId { get; set; }
        [Required]
        [StringLength(12)]
        public string MonthName { get; set; }
        public byte MonthNum { get; set; }
        [Column("MonthName_Bangla")]
        [StringLength(50)]
        public string MonthNameBangla { get; set; }
    }
}
