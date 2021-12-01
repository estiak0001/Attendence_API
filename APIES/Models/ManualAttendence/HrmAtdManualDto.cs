using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.ManualAttendence
{
    public class HrmAtdManualDto
    {
        public string ManualCode { get; set; }
        public string BulkEntryId { get; set; }
        public string AttdEntryType { get; set; }
        public string EmployeeId { get; set; }
        public string AttendanceTypeCode { get; set; }   
        public string Date { get; set; }
        public string Time { get; set; }   
        public string Remarks { get; set; }
        public string Luser { get; set; }      
        public string Ldate { get; set; }
        public string Lip { get; set; }
        public string Lmac { get; set; }
        public string ModifyDate { get; set; }
        public string CompanyCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string type { get; set; }
    }
}
