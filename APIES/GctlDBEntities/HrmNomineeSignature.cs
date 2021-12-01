using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_NomineeSignature")]
    public partial class HrmNomineeSignature
    {
        [Column("autoId")]
        public int AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("NomineeID")]
        [StringLength(50)]
        public string NomineeId { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Required]
        [StringLength(50)]
        public string ImgType { get; set; }
        public long ImgSize { get; set; }
    }
}
