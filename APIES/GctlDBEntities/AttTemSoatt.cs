using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Att_Tem_SOAtt")]
    public partial class AttTemSoatt
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string DivisionName { get; set; }
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [Required]
        [StringLength(10)]
        public string AttStatus { get; set; }
        public int Strength { get; set; }
        public int DeviceAccessedEmployee { get; set; }
        [Required]
        [StringLength(30)]
        public string InTime { get; set; }
    }
}
