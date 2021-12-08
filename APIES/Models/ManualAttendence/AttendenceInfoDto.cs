using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.ManualAttendence
{
    public class AttendenceInfoDto
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool inTime { get; set; }
        public bool outTime { get; set; }
        public string imageUrl { get; set; }
        public List<AttListDto> AttendenceList { get; set; }
    }
}
