﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_HolidayType")]
    public partial class HrmAtdHolidayType
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [StringLength(50)]
        public string HolidayType { get; set; }
        [StringLength(300)]
        public string HolidayTypeName { get; set; }
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
