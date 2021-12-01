using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Att_Tem_DASR_2")]
    public partial class AttTemDasr2
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string LineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DesignationCode { get; set; }
        public int Strength { get; set; }
        public int DeviceAccessedEmployee { get; set; }
        public int DeviceNoAccessedEmployee { get; set; }
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
    }
}
