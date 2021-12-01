using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmpDigitalSignature")]
    public partial class HrmEmpDigitalSignature
    {
        [Column("autoId")]
        public int AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] DigitalSignature { get; set; }
        [Required]
        [StringLength(50)]
        public string ImgType { get; set; }
        public long ImgSize { get; set; }
    }
}
