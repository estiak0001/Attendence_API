using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_Tem_DSRM2")]
    public partial class HrmAttdTemDsrm2
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }
        public int Strength { get; set; }
        public int DeviceAccessedEmployee { get; set; }
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
    }
}
