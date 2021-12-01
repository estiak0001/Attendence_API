using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Employee_Test")]
    public partial class HrmEmployeeTest
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string FatherName { get; set; }
        [Required]
        [StringLength(100)]
        public string MotherName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirthCertificate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirthOrginal { get; set; }
        [StringLength(100)]
        public string BirthCertificateNo { get; set; }
        public string PlaceOfBirth { get; set; }
        [Required]
        [StringLength(50)]
        public string SexCode { get; set; }
        [Required]
        [StringLength(50)]
        public string BloodGroupCode { get; set; }
        [Required]
        [StringLength(50)]
        public string NationalityCode { get; set; }
        [Required]
        [Column("NationalIDNO")]
        [StringLength(100)]
        public string NationalIdno { get; set; }
        [Required]
        [StringLength(50)]
        public string ReligionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string MaritalStatusCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarriageDate { get; set; }
        [StringLength(50)]
        public string NoOfSon { get; set; }
        [StringLength(50)]
        public string NoOfDaughters { get; set; }
        [StringLength(200)]
        public string CardNo { get; set; }
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
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string PersonalEmail { get; set; }
        [Required]
        [StringLength(100)]
        public string Telephone { get; set; }
        [StringLength(100)]
        public string TinNo { get; set; }
        public string ExtraCurriActivities { get; set; }
        public string Remarks { get; set; }
        [StringLength(200)]
        public string FirstNameBangla { get; set; }
        [StringLength(50)]
        public string LastNameBangla { get; set; }
        [StringLength(100)]
        public string PhotoUrl { get; set; }
    }
}
