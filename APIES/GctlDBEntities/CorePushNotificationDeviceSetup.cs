using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_PushNotificationDeviceSetup")]
    public partial class CorePushNotificationDeviceSetup
    {
        [Key]
        [StringLength(10)]
        public string NotificationCode { get; set; }
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column("DeviceID")]
        public string DeviceId { get; set; }
    }
}
