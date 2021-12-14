using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.Leave
{
    public class LeaveBalanceStatus
    {
        public string ShortName { get; set; }
        public decimal? NoOfDay { get; set; }
        public decimal? Taken { get; set; }
        public decimal? Balance { get; set; }
    }
}
