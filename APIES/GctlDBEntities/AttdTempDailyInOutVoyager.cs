using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Attd_Temp_DailyInOut_Voyager")]
    public partial class AttdTempDailyInOutVoyager
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [StringLength(100)]
        public string DesignationName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string InTime { get; set; }
        [StringLength(50)]
        public string OutTime { get; set; }
        [StringLength(50)]
        public string OnDuty { get; set; }
        [StringLength(50)]
        public string OffDuty { get; set; }
        [StringLength(50)]
        public string Overtime { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
