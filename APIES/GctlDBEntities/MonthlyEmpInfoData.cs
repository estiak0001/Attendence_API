using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    public partial class MonthlyEmpInfoData
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [StringLength(50)]
        public string BranchCode { get; set; }
        [StringLength(50)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string SectionCode { get; set; }
        [StringLength(50)]
        public string LineCode { get; set; }
        [StringLength(50)]
        public string DesignationCode { get; set; }
        [StringLength(50)]
        public string GradeCode { get; set; }
        [StringLength(50)]
        public string EmpTypeCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoiningDate { get; set; }
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
        public int? Weekend { get; set; }
        public int? Holiday { get; set; }
        [Column("CL", TypeName = "numeric(18, 2)")]
        public decimal? Cl { get; set; }
        [Column("ML", TypeName = "numeric(18, 2)")]
        public decimal? Ml { get; set; }
        [Column("EL")]
        public int? El { get; set; }
        [Column("OT", TypeName = "numeric(18, 2)")]
        public decimal? Ot { get; set; }
        [Column("ActOT", TypeName = "numeric(18, 2)")]
        public decimal? ActOt { get; set; }
        public int? AttendBonus { get; set; }
        [StringLength(50)]
        public string MonthName { get; set; }
        public int? YearName { get; set; }
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
    }
}
