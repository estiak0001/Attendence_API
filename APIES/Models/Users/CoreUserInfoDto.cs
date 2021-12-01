using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.Users
{
    public class CoreUserInfoDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string AccessCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? Dob { get; set; }
        public string OffPhone { get; set; }
        public string PerPhone { get; set; }
        public string OffEmail { get; set; }
        public string PerEmail { get; set; }
        public string Role { get; set; }
        public string SingleSession { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Luser { get; set; }
        public DateTime? Ldate { get; set; }
        public string Lip { get; set; }
        public string Lmac { get; set; }
        public string WorkStation { get; set; }
        public string Regulation { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Token { get; set; }
        public string AppVersion { get; set; }
        //public string SalesConcernID { get; set; }
        //public string SalseTeamName { get; set; }
        //public decimal VatPercentage { get; set; }
        //public decimal? OrderTarget { get; set; }

        // new
        //public string Hocid { get; set; }
        //public string SalesConcernId { get; set; }
        //public string WarehouseId { get; set; }
        //public string ShowRoomId { get; set; }
        //public string Scwtsid { get; set; }
        //public string DistrictId { get; set; }
        //public string ThanaCode { get; set; }
    }
}
