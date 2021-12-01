﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_TimeCalculation2_TBSC_Dp_Se")]
    public partial class HrmAttdTimeCalculation2TbscDpSe
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        public TimeSpan TotalTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
    }
}
