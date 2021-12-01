using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temp_T_DashboardTimeSum_LS")]
    public partial class TempTDashboardTimeSumLs
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string TotalHours { get; set; }
        [Column("TotHrswith_WH", TypeName = "decimal(18, 2)")]
        public decimal? TotHrswithWh { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotAvgHrs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
    }
}
