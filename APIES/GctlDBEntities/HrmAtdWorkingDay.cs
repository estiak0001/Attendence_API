﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_WorkingDay")]
    public partial class HrmAtdWorkingDay
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkingDayCode { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkingDayName { get; set; }
        [StringLength(50)]
        public string WorkingDayType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WorkingDayDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ToDate { get; set; }
        public byte NoOfDays { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }
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
