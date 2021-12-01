using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeDailyMovementInfo")]
    public partial class HrmEmployeeDailyMovementInfo
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("empMovmentID")]
        [StringLength(50)]
        public string EmpMovmentId { get; set; }
        [Column("EmployeeID")]
        [StringLength(50)]
        public string EmployeeId { get; set; }
        [Column("MainCompanyID")]
        [StringLength(50)]
        public string MainCompanyId { get; set; }
        [Column("BranchID")]
        [StringLength(50)]
        public string BranchId { get; set; }
        [Column("DivisionID")]
        [StringLength(50)]
        public string DivisionId { get; set; }
        [Column("CustomerID")]
        [StringLength(50)]
        public string CustomerId { get; set; }
        [Column("DestinationFromID")]
        [StringLength(50)]
        public string DestinationFromId { get; set; }
        [Column("DestinationToID")]
        [StringLength(50)]
        public string DestinationToId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MovementDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        [Column("VehicleTypeID")]
        [StringLength(50)]
        public string VehicleTypeId { get; set; }
        [Column("NotifyTypeID")]
        [StringLength(50)]
        public string NotifyTypeId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ConveyanceAmount { get; set; }
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
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
        [Required]
        [StringLength(10)]
        public string CompanyCode { get; set; }
        [Column("OtherTypeID")]
        [StringLength(50)]
        public string OtherTypeId { get; set; }
    }
}
