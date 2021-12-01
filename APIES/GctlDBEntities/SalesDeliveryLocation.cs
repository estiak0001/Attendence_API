using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Sales_DeliveryLocation")]
    public partial class SalesDeliveryLocation
    {
        [Key]
        [StringLength(50)]
        public string DeliveryLocationCode { get; set; }
        [Column("CustomerID")]
        [StringLength(50)]
        public string CustomerId { get; set; }
        [StringLength(200)]
        public string LocationAddress { get; set; }
        [StringLength(50)]
        public string ContactPerson { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Designation { get; set; }
    }
}
