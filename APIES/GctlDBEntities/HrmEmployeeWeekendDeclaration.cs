﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeWeekendDeclaration")]
    public partial class HrmEmployeeWeekendDeclaration
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [Column("EWDId")]
        [StringLength(50)]
        public string Ewdid { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(500)]
        public string Remark { get; set; }
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
        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("EmployeeID2")]
        [StringLength(50)]
        public string EmployeeId2 { get; set; }
    }
}
