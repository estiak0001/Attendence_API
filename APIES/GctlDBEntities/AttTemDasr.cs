using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Att_Tem_DASR")]
    public partial class AttTemDasr
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string LineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [Required]
        [StringLength(10)]
        public string AttStatus { get; set; }
    }
}
