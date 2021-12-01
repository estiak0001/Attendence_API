using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeContactInfo")]
    public partial class HrmEmployeeContactInfo
    {
        [Key]
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        public string ParmanentAddress { get; set; }
        [StringLength(300)]
        public string ParmanentPostOffice { get; set; }
        [StringLength(300)]
        public string ParmanentThana { get; set; }
        [StringLength(50)]
        public string ParmanentPostCode { get; set; }
        [StringLength(50)]
        public string ParmanentDistrict { get; set; }
        [StringLength(50)]
        public string ParmanentPhone { get; set; }
        public string PresentAddress { get; set; }
        [StringLength(300)]
        public string PresentPostOffice { get; set; }
        [StringLength(300)]
        public string PresentThana { get; set; }
        [StringLength(50)]
        public string PresentPostCode { get; set; }
        [StringLength(50)]
        public string PresentDistrict { get; set; }
        [StringLength(50)]
        public string PresentMobile { get; set; }
        [StringLength(50)]
        public string PresentPhone { get; set; }
        [StringLength(50)]
        public string PresentFax { get; set; }
        [StringLength(200)]
        public string PresentEmail { get; set; }
        public string EmContactName1 { get; set; }
        [StringLength(50)]
        public string EmContactRelation1 { get; set; }
        public string EmContactAddress1 { get; set; }
        [StringLength(50)]
        public string EmContactPhone1 { get; set; }
        [StringLength(100)]
        public string EmContactMobile1 { get; set; }
        [StringLength(50)]
        public string EmContactFax1 { get; set; }
        [StringLength(100)]
        public string EmContactEmail { get; set; }
        public string EmContactName2 { get; set; }
        [StringLength(50)]
        public string EmContactRelation2 { get; set; }
        public string EmContactAddress2 { get; set; }
        [StringLength(50)]
        public string EmContactPhone2 { get; set; }
        [StringLength(100)]
        public string EmContactMobile2 { get; set; }
        [StringLength(50)]
        public string EmContactFax2 { get; set; }
        [StringLength(100)]
        public string EmContactEmai2 { get; set; }
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
        public string ParmanentAddressBangla { get; set; }
        public string PresentAddressBangla { get; set; }
    }
}
