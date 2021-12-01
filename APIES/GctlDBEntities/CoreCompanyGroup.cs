﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_Company_Group")]
    public partial class CoreCompanyGroup
    {
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
        [StringLength(10)]
        public string CompanyShortName { get; set; }
        public string ImgTitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [StringLength(100)]
        public string ZipCode { get; set; }
        [StringLength(150)]
        public string City { get; set; }
        [StringLength(150)]
        public string State { get; set; }
        public string Country { get; set; }
        [StringLength(150)]
        public string Phone1 { get; set; }
        [StringLength(100)]
        public string Phone2 { get; set; }
        [StringLength(100)]
        public string Fax { get; set; }
        [StringLength(150)]
        public string HotLine { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        [Column("URL")]
        public string Url { get; set; }
        [StringLength(100)]
        public string RegNo { get; set; }
        [Column("TIN")]
        [StringLength(150)]
        public string Tin { get; set; }
        public string BackImage { get; set; }
        [StringLength(150)]
        public string BaseCurrency { get; set; }
        [StringLength(100)]
        public string GroupName { get; set; }
        [Column("GShort_name")]
        [StringLength(100)]
        public string GshortName { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(100)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(150)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [StringLength(50)]
        public string Licence { get; set; }
    }
}
