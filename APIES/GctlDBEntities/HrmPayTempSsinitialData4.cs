using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_SSInitialData_4")]
    public partial class HrmPayTempSsinitialData4
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("OT")]
        public int? Ot { get; set; }
        [Column("ActOT")]
        public int? ActOt { get; set; }
    }
}
