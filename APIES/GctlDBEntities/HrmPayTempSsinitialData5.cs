using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Pay_Temp_SSInitialData_5")]
    public partial class HrmPayTempSsinitialData5
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(100)]
        public string LineName { get; set; }
        [StringLength(100)]
        public string DesignationName { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [StringLength(50)]
        public string LineCode { get; set; }
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [StringLength(10)]
        public string JoiningDate { get; set; }
        [StringLength(50)]
        public string GradeName { get; set; }
        [StringLength(50)]
        public string EmpType { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? GrossSalary { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Medical { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Conveyance { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? Food { get; set; }
        public int? Present { get; set; }
        public int? Late { get; set; }
        public int? Absent { get; set; }
        [Column("OT")]
        public int? Ot { get; set; }
        [Column("ActOT")]
        public int? ActOt { get; set; }
        [Column("CL")]
        public int? Cl { get; set; }
        [Column("ML")]
        public int? Ml { get; set; }
        [Column("EL")]
        public int? El { get; set; }
        public int? AttendBonus { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
        [Column("Ex_String_1")]
        [StringLength(100)]
        public string ExString1 { get; set; }
        [Column("Ex_String_2")]
        [StringLength(100)]
        public string ExString2 { get; set; }
        [Column("Ex_String_3")]
        [StringLength(100)]
        public string ExString3 { get; set; }
        [Column("Ex_String_4")]
        [StringLength(100)]
        public string ExString4 { get; set; }
        [Column("Ex_String_5")]
        [StringLength(100)]
        public string ExString5 { get; set; }
        [Column("EInt_1")]
        public int? Eint1 { get; set; }
        [Column("EInt_2")]
        public int? Eint2 { get; set; }
        [Column("EInt_3")]
        public int? Eint3 { get; set; }
        [Column("EInt_4")]
        public int? Eint4 { get; set; }
        [Column("EInt_5")]
        public int? Eint5 { get; set; }
        [Column("EDate_1", TypeName = "datetime")]
        public DateTime? Edate1 { get; set; }
        [Column("EDate_2", TypeName = "datetime")]
        public DateTime? Edate2 { get; set; }
        [Column("EDate_3", TypeName = "datetime")]
        public DateTime? Edate3 { get; set; }
        [StringLength(1)]
        public string IsSalApp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SalAppDate { get; set; }
        [StringLength(50)]
        public string ProcessType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(500)]
        public string Details { get; set; }
        [StringLength(50)]
        public string ProcessId { get; set; }
        [StringLength(50)]
        public string ApprovalId { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
    }
}
