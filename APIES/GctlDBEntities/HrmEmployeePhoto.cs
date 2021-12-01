using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeePhoto")]
    public partial class HrmEmployeePhoto
    {
        [Column("autoId")]
        public int AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Required]
        [StringLength(50)]
        public string ImgType { get; set; }
        public long ImgSize { get; set; }
    }
}
