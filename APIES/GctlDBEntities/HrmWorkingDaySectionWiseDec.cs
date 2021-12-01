using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_WorkingDaySectionWiseDec")]
    public partial class HrmWorkingDaySectionWiseDec
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("WDSWD_ID")]
        [StringLength(50)]
        public string WdswdId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkingDayCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WorkingDayDate { get; set; }
    }
}
