using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Temp_Overtime_Voyager")]
    public partial class HrmTempOvertimeVoyager
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public TimeSpan? Overtime { get; set; }
        public TimeSpan? Overtime2 { get; set; }
    }
}
