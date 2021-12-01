using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Temp_DASR_Email")]
    public partial class HrmAttdTempDasrEmail
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(50)]
        public string LineName { get; set; }
        [Required]
        [StringLength(50)]
        public string DesignationName { get; set; }
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
        public int Strength { get; set; }
        public int DeviceAccessedEmployee { get; set; }
        public int DeviceNoAccessedEmployee { get; set; }
        [Required]
        [StringLength(50)]
        public string DivisionName { get; set; }
        [Required]
        [StringLength(50)]
        public string AttStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string InTime { get; set; }
        [Required]
        [StringLength(50)]
        public string Sick { get; set; }
    }
}
