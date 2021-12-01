using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_TecnicalSkillType")]
    public partial class HrmTecnicalSkillType
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("TecnicalSkillTypeID")]
        [StringLength(50)]
        public string TecnicalSkillTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string TecnicalSkillTypeName { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "datetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
