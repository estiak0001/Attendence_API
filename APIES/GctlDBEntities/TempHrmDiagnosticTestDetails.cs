using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temp_HRM_DiagnosticTestDetails")]
    public partial class TempHrmDiagnosticTestDetails
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("TestID")]
        [StringLength(100)]
        public string TestId { get; set; }
        [StringLength(50)]
        public string DiagnosticTestNo { get; set; }
        [Column("ServiceChageID")]
        [StringLength(100)]
        public string ServiceChageId { get; set; }
        [Column("TechnicianID")]
        [StringLength(50)]
        public string TechnicianId { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
