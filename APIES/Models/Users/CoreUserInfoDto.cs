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

        public string CompanyCode { get; set; }
        public string Company { get; set; }
        public string BranchCode { get; set; }
        public string Branch { get; set; }
        public string DivisionCode { get; set; }
        public string Division { get; set; }
        public string DepartmentCode { get; set; }
        public string Department { get; set; }
        public string DesignationCode { get; set; }
        public string Designation { get; set; }
        public string EmpTypeCode { get; set; }
    }
}
