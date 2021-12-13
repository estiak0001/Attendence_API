
using APIES.GctlDBEntities;
using APIES.Helper;
using APIES.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PXLibrary;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApexAPI.Services
{
    public interface IUserService
    {
        //bool CheackValidity(string DeviceID);
        //CoreUserDevice GetByDeviceID(string deviceID);
        //bool SendEmail(string emailid);
        //CoreUserInfo GetByEmailandCode(string emailid, string ConfirmationCode);
        //bool DeviceIDExists(string DeviceID);
        //void AddUserDevice(CoreUserDevice coreUserDevice);
        //bool IsValidEmail(string emailid);
        //bool IsExistEmail(string emailid);
        CoreUserInfo Authenticate(string username, string password);
        //InvDefSalesConcern GetSalesConcerns(string SalesConcernId);
        IEnumerable<CoreUserInfo> GetAll();
        CoreUserInfo GetById(int id);
        CoreUserInfo Create(CoreUserInfo user, string password);
        void Update(CoreUserInfo user, string password = null);
        void Delete(int id);
        bool Save();
        //TotalTargetDTO orderTarget(string TSO);

        CoreUserInfoDto getUser(string EmployeeID);
    }

    public class UserService : IUserService
    {
        private GctlDbContext _context;


        public UserService(GctlDbContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }


        private readonly AppSettings _appSettings;
        public CoreUserInfo Authenticate(string username, string password)
        {

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.CoreUserInfo.SingleOrDefault(x => x.Username == username);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPassword(password, user.Password))
                return null;

            // authentication successful so generate jwt token

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            //user.Token = tokenHandler.WriteToken(token);
            var returnUser = user;

            return user.WithoutPassword();
        }
        
        public IEnumerable<CoreUserInfo> GetAll()
        {
            return _context.CoreUserInfo;
        }

        public CoreUserInfo GetById(int id)
        {
            return _context.CoreUserInfo.Find(id);
        }

        public CoreUserInfo Create(CoreUserInfo user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.CoreUserInfo.Any(x => x.Username == user.Username))
                throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            //user.PasswordHash = passwordHash;
            //user.PasswordSalt = passwordSalt;
            //_context.Users.Add(user);
            //_context.SaveChanges();

            return user;
        }

        public void Update(CoreUserInfo userParam, string password = null)
        {
            var user = _context.CoreUserInfo.Find(userParam.Id);

            if (user == null)
                throw new AppException("User not found");

            // update username if it has changed
            if (!string.IsNullOrWhiteSpace(userParam.Username) && userParam.Username != user.Username)
            {
                // throw error if the new username is already taken
                if (_context.CoreUserInfo.Any(x => x.Username == userParam.Username))
                    throw new AppException("Username " + userParam.Username + " is already taken");

                user.Username = userParam.Username;
            }

            // update user properties if provided
            if (!string.IsNullOrWhiteSpace(userParam.FirstName))
                user.FirstName = userParam.FirstName;

            if (!string.IsNullOrWhiteSpace(userParam.LastName))
                user.LastName = userParam.LastName;

            // update password if provided
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                //user.PasswordHash = passwordHash;
                //user.PasswordSalt = passwordSalt;
            }

            _context.CoreUserInfo.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.CoreUserInfo.Find(id);
            if (user != null)
            {
                _context.CoreUserInfo.Remove(user);
                _context.SaveChanges();
            }
        }

        // private helper methods

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPassword(string password, string haspass)
        {
            PXlibrary Pxlib = new PXlibrary();
            string Userpassword = "";
            Pxlib.PXEncode(ref Userpassword, password);
            if (Userpassword != haspass)
            {
                return false;
            }
            return true;
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }

        //public bool CheackValidity(string DeviceID)
        //{
        //    return _context.CoreUserDevice.Any(a => a.DeviceId == DeviceID);
        //}

        //public void updateConfCode(string emailid, string randomCode)
        //{
        //    var user = _context.CoreUserInfo.FirstOrDefault(u => u.OffEmail == emailid);
        //    user.EmailConfCode = randomCode;
        //    _context.SaveChanges();
        //}

        //public bool SendEmail(string emailid)
        //{
        //    Random generator = new Random();
        //    String randomecode = generator.Next(0, 999999).ToString("D6");
        //    bool t = false;
        //    try
        //    {
        //        var fromemail = new MailAddress("estiak.eng@gmail.com");
        //        var tomemail = new MailAddress(emailid);
        //        //var message = new MailMessage();
        //        //message.To.Add(new MailAddress(emailid));
        //        //message.From = new MailAddress("estiak.eng@gmail.com");
        //        //message.Subject = "This Message provided by Apex Husain!";
        //        //message.Body ="Your Code is - " + randomecode;
        //        //message.IsBodyHtml = false;

        //        var smtp = new SmtpClient
        //        {
        //            Host = "smtp.gmail.com",
        //            Port = 587,
        //            UseDefaultCredentials = true,
        //            DeliveryMethod = SmtpDeliveryMethod.Network,
        //            EnableSsl = true,
        //            Credentials = new NetworkCredential(fromemail.Address, "Esti@kAhmed098321")
        //        };
        //        using (var message = new MailMessage(fromemail, tomemail) { Subject = "test", Body = "Your code is - " + randomecode }) { smtp.Send(message); }

        //        updateConfCode(emailid, randomecode);
        //        t = true;
        //    }
        //    catch
        //    {
        //        t = false;
        //    }

        //    return t;
        //}

        public bool IsValidEmail(string emailid)
        {
            bool t = false;
            try
            {

                var addr = new System.Net.Mail.MailAddress(emailid);
                if (addr.Address != null)
                    t = true;
            }
            catch
            {
                t = false;
            }
            return t;
        }

        public bool IsExistEmail(string emailid)
        {
            return _context.CoreUserInfo.Any(a => a.OffEmail == emailid);
        }

        //public CoreUserInfo GetByEmailandCode(string emailid, string ConfirmationCode)
        //{
        //    var user = _context.CoreUserInfo.FirstOrDefault(u => u.OffEmail == emailid && u.EmailConfCode == ConfirmationCode);
        //    return user;
        //}
        //public CoreUserDevice GetByDeviceID(string deviceID)
        //{
        //    var userDevice = _context.CoreUserDevice.FirstOrDefault(u => u.DeviceId == deviceID);
        //    return userDevice;
        //}
        //[Obsolete]
        //public void AddUserDevice(CoreUserDevice coreUserDevice)
        //{
        //    if (coreUserDevice.DeviceId == "")
        //    {
        //        throw new ArgumentNullException(nameof(coreUserDevice.DeviceId));
        //    }

        //    if (coreUserDevice.EmployeeId == "")
        //    {
        //        throw new ArgumentNullException(nameof(coreUserDevice.EmployeeId));
        //    }


        //    var MaxID = _context.CustomIDCoreUserDevice.FromSql("Select FORMAT(ISNULL(MAX(RIGHT(UserDeviceID,3)),0)+1,'000') as UserDeviceID from Core_UserDevice").Select(x => new CustomIDCoreUserDevice()
        //    {
        //        UserDeviceId = x.UserDeviceId
        //    }).FirstOrDefault();


        //    if (MaxID.UserDeviceId == "")
        //    {
        //        throw new ArgumentNullException(nameof(MaxID.UserDeviceId));
        //    }

        //    coreUserDevice.UserDeviceId = MaxID.UserDeviceId;
        //    coreUserDevice.Status = "Pending";
        //    _context.CoreUserDevice.Add(coreUserDevice);
        //}

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public CoreUserInfoDto getUser(string EmployeeID)
        {

            var result = (from offic in _context.HrmEmployeeOfficialInfo.Where(x => x.EmployeeId == EmployeeID).AsEnumerable()
                          join emm in _context.HrmEmployee
                            on new { X1 = offic.EmployeeId } equals new { X1 = emm.EmployeeId }
                            into rmp
                          from gen in rmp.DefaultIfEmpty()
                          join dess in _context.HrmDefDesignation
                            on new { X1 = offic.DesignationCode } equals new { X1 = dess.DesignationCode }
                            into rmpdes
                          from des in rmpdes.DefaultIfEmpty()
                          join depp in _context.HrmDefDepartment
                            on new { X1 = offic.DepartmentCode } equals new { X1 = depp.DepartmentCode }
                            into rmpdep
                          from dep in rmpdep.DefaultIfEmpty()

                          join gg in _context.HrmDefGrade
                            on new { X1 = offic.GradeCode } equals new { X1 = gg.GradeCode }
                            into rmpgg
                          from gr in rmpgg.DefaultIfEmpty()

                          select new
                          {
                              EmployeeID = offic.EmployeeId,
                              FirstName = gen.FirstName,
                              LastName = gen.LastName,
                              FatherName = gen.FatherName,
                              MotherName = gen.MotherName,
                              //FirstNameBangla = gen.FirstNameBangla,
                              //LastNameBangla = gen.LastNameBangla,
                              DateOfBirthOrginal = ((DateTime)gen.DateOfBirthOrginal).ToString("dd/MM/yyyy"),
                              BirthCertificateNo = gen.BirthCertificateNo,
                              SexCode = gen.SexCode,
                              BloodGroupCode = gen.BloodGroupCode,
                              NationalityCode = gen.NationalityCode,
                              NationalIDNO = gen.NationalIdno,
                              ReligionCode = gen.ReligionCode,
                              MaritalStatusCode = gen.MaritalStatusCode,
                              Telephone = gen.Telephone,
                              PersonalEmail = gen.PersonalEmail,
                              PhotoUrl = gen.PhotoUrl,
                              SignatureImageUrl = gen.SignatureImageUrl,
                              CompanyCode = offic.CompanyCode,
                              BranchCode = offic.BranchCode,
                              DepartmentCode = offic.DepartmentCode,
                              DesignationCode = offic.DesignationCode,
                              ShiftCode = offic.ShiftCode,
                              EmpTypeCode = offic.EmpTypeCode,
                              EmploymentNatureId = offic.EmploymentNatureId,
                              GrossSalary = offic.GrossSalary,
                              ReportingTo = offic.ReportingTo,
                              HOD = offic.Hod,
                              JoiningDate = ((DateTime)offic.JoiningDate).ToString("dd/MM/yyyy"),
                              EmployeeStatus = offic.EmployeeStatus,
                              MobileNo = offic.MobileNo,
                              Email = offic.Email,
                              EmployeeFullName = gen.FirstName + " " + gen.LastName,
                              designationNAme = des.DesignationName,
                              DepartmentName = dep.DepartmentName,
                              PlaceOfBirth = gen.PlaceOfBirth,
                              gradeName = gr.GradeName,
                              gradeCode = offic.GradeCode,
                              curr = offic.CurrencyCode,
                              paymentPeriod = offic.PaymentPeriodId,
                              prbationPeriod = offic.ProbationPeriod,
                              proabType = offic.ProbationPeriodType,
                              
                          }).AsEnumerable().Select(a => new CoreUserInfoDto()
                          {
                              EmployeeId = a.EmployeeID,
                              FirstName = a.FirstName,
                              LastName = a.LastName,
                              CompanyCode = a.CompanyCode,
                              BranchCode = a.BranchCode,
                              DepartmentCode = a.DepartmentCode,
                              DesignationCode = a.DesignationCode,
                              EmpTypeCode = a.EmpTypeCode,
                              Type = a.EmpTypeCode,
                              Department = a.DepartmentName,
                              Designation = a.designationNAme,
                          }).FirstOrDefault();
            return result;
        }
        //public bool DeviceIDExists(string DeviceID)
        //{
        //    if (DeviceID == "")
        //    {
        //        throw new ArgumentNullException(nameof(DeviceID));
        //    }
        //    return _context.CoreUserDevice.Any(a => a.DeviceId == DeviceID);
        //}

        //[Obsolete]
        //public TotalTargetDTO orderTarget(string TSO)
        //{
        //    DateTime now = DateTime.Now;
        //    var curr = now.ToString("yyyy-MM-dd");
        //    var curr2 = "2020-01-01";
        //    var result = _context.targetQTY.FromSqlRaw<TotalTargetDTO>("select distinct ISNull(cast(sum(trd.Quantity) AS decimal(18,2)), 0) Totaltarget from Sales_ManualSalesTargetEntry tr left join Sales_ManualSalesTargetDetails trd on tr.STID = trd.STID and trd.TSO= '" + TSO + "' where '" + TSO + "' IN (select * from SplitString(tr.TSO, ',')) and '" + curr2 + "' between tr.FromDate and tr.ToDate").FirstOrDefault();
        //    return result;
        //}
    }
}
