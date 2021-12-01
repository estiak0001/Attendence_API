using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_TempImage")]
    public partial class HrmTempImage
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("picture", TypeName = "image")]
        public byte[] Picture { get; set; }
        [StringLength(50)]
        public string EmployeeCode { get; set; }
    }
}
