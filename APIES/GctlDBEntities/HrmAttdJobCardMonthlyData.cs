using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_JobCardMonthlyData")]
    public partial class HrmAttdJobCardMonthlyData
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Time { get; set; }
        [StringLength(50)]
        public string ProcessType { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
        [StringLength(1)]
        public string IsSalApp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SalAppDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
    }
}
