using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeDailyMovementInfoDetailsOther")]
    public partial class HrmEmployeeDailyMovementInfoDetailsOther
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("EDMDetailsID")]
        [StringLength(50)]
        public string EdmdetailsId { get; set; }
        [Required]
        [Column("EDMNo")]
        [StringLength(50)]
        public string Edmno { get; set; }
        [StringLength(200)]
        public string PlaningDate { get; set; }
        [Column("OtherCUstomer")]
        [StringLength(300)]
        public string OtherCustomer { get; set; }
        public string VisitParticuler { get; set; }
        [Column("AreaID")]
        [StringLength(50)]
        public string AreaId { get; set; }
        [StringLength(50)]
        public string StartPoint { get; set; }
        [StringLength(50)]
        public string EndPoint { get; set; }
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
        public string Remarks { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
