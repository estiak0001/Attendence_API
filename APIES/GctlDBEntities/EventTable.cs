using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    public partial class EventTable
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Required]
        [StringLength(100)]
        public string Subject { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        [StringLength(10)]
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}
