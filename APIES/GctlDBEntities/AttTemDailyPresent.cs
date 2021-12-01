﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Att_Tem_DailyPresent")]
    public partial class AttTemDailyPresent
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(100)]
        public string DesignationName { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(100)]
        public string LineName { get; set; }
        [Required]
        [StringLength(11)]
        public string Date { get; set; }
        [Required]
        [StringLength(30)]
        public string InTime { get; set; }
        [Required]
        [StringLength(30)]
        public string OutTime { get; set; }
        [Required]
        [StringLength(30)]
        public string Late { get; set; }
        [Required]
        [Column("OT")]
        [StringLength(30)]
        public string Ot { get; set; }
        [Required]
        [StringLength(10)]
        public string AttStatus { get; set; }
        public int MachineId { get; set; }
    }
}
