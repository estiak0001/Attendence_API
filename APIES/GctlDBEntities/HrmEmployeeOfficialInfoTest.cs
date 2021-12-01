using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeOfficialInfo_test")]
    public partial class HrmEmployeeOfficialInfoTest
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Key]
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyCode { get; set; }
        [Required]
        [StringLength(50)]
        public string BranchCode { get; set; }
        [StringLength(50)]
        public string DivisionCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpTypeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmploymentNatureId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GrossSalary { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrencyCode { get; set; }
        [Required]
        [Column("PaymentPeriodID")]
        [StringLength(50)]
        public string PaymentPeriodId { get; set; }
        [Required]
        [StringLength(50)]
        public string DisbursementMethodId { get; set; }
        [Required]
        [StringLength(50)]
        public string ShiftCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string ReportingTo { get; set; }
        [Required]
        [Column("HOD")]
        [StringLength(50)]
        public string Hod { get; set; }
        [Required]
        [StringLength(100)]
        public string MobileNo { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string AppointmentLetterNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppointmentLetterDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoiningDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JoiningSalary { get; set; }
        [Required]
        [StringLength(100)]
        public string ProbationPeriodType { get; set; }
        [Required]
        [StringLength(50)]
        public string ProbationPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmeDate { get; set; }
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
        [Column("CompanyCode_Session")]
        [StringLength(50)]
        public string CompanyCodeSession { get; set; }
        [Required]
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [StringLength(50)]
        public string StepNoId { get; set; }
        [Column("TecnicalSkillTypeID")]
        [StringLength(50)]
        public string TecnicalSkillTypeId { get; set; }
        [Column("SalaryScaleID")]
        [StringLength(50)]
        public string SalaryScaleId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEndDate { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [StringLength(50)]
        public string LineCode { get; set; }
        [Column("AttendenceID")]
        [StringLength(50)]
        public string AttendenceId { get; set; }
    }
}
