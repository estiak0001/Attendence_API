using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attendance")]
    public partial class HrmAttendance
    {
        [Required]
        [Column("DesignationID")]
        [StringLength(50)]
        public string DesignationId { get; set; }
        [Required]
        [StringLength(50)]
        public string Designation { get; set; }
    }
}
