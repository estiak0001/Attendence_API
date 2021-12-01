﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Def_Line")]
    public partial class HrmDefLine
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string LineCode { get; set; }
        [StringLength(100)]
        public string LineName { get; set; }
        [StringLength(50)]
        public string LineCapacity { get; set; }
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
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [Required]
        [StringLength(100)]
        public string BanglaLine { get; set; }
    }
}
