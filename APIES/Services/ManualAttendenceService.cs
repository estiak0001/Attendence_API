using APIES.GctlDBEntities;
using APIES.Helper.ModelHelper;
using APIES.Models.Holiday;
using APIES.Models.Leave;
using APIES.Models.ManualAttendence;
using APIES.Models.Report;
using APIES.Models.Weekend;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace APIES.Services
{
    public class ManualAttendenceService : IManualAttendenceService
    {
        private readonly GctlDbContext _context;
        public static string tesd;

        public ManualAttendenceService(GctlDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [Obsolete]
        public void AddManualAttendence(HrmAtdManual hrmAtdManual, string type)
        {
            if (hrmAtdManual.EmployeeId == "")
            {
                throw new ArgumentNullException(nameof(hrmAtdManual.EmployeeId));
            }

            if (hrmAtdManual == null)
            {
                throw new ArgumentNullException(nameof(hrmAtdManual));
            }
            var MaxID = _context.customID.FromSql("Select ISNULL(MAX(Cast(ManualCode as int)),0)+1 as Code from HRM_ATD_Manual").Select(x => new CustomID()
            {
                Code = x.Code
            }).FirstOrDefault();
            if (MaxID.Code.ToString() == "")
            {
                throw new ArgumentNullException(nameof(MaxID.Code));
            }
            hrmAtdManual.ManualCode = MaxID.Code.ToString();
            hrmAtdManual.AttdEntryType = "Mobile App";
            if(type == "In")
            {
                hrmAtdManual.AttendanceTypeCode = "1";
            }
            else
            {
                hrmAtdManual.AttendanceTypeCode = "2";
            }
            hrmAtdManual.Date = DateTime.Today;
            hrmAtdManual.Time = DateTime.Now;
            _context.HrmAtdManual.Add(hrmAtdManual);
        }

        public CustomID GetID()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HrmAtdManual> GetManualAttendence()
        {
            throw new NotImplementedException();
        }

        public void UpdateManualAttendence(HrmAtdManual hrmAtdManual)
        {
            throw new NotImplementedException();
        }

        public void DeleteManualAttendence(HrmAtdManual hrmAtdManual)
        {
            throw new NotImplementedException();
        }

        public bool ManualAttendenceExists(string salseDaliveryLocation)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public AttendenceInfoDto GetLandingInfo(string EmployeeID)
        {
            //var lastIn = _context.HrmAtdManual.Where(x => x.EmployeeId == EmployeeID).OrderBy(x => x.Time).FirstOrDefault();

            var isData = _context.HrmAtdMachineData.Where(e => e.FingerPrintId == EmployeeID && e.Date == DateTime.Today).ToList();
            AttendenceInfoDto result = new AttendenceInfoDto();
            List<AttListDto> datalist = new List<AttListDto>();
            if (isData.Count() != 0)
            {
                 result = (from head in _context.HrmAtdMachineData.Where(e => e.FingerPrintId == EmployeeID).AsEnumerable()
                              select new AttendenceInfoDto()
                              {
                                  Date = head.Date,
                                  Time = DateTime.ParseExact(String.Format("{0:dd/MM/yyyy h:mm:ss tt}", head.Time), "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                                  inTime = (_context.HrmAtdMachineData.Where(e => e.FingerPrintId == EmployeeID && e.Date == DateTime.Today).ToList().Count())%2 == 0 ? true : false,
                                  outTime = (_context.HrmAtdMachineData.Where(e => e.FingerPrintId == EmployeeID && e.Date == DateTime.Today).ToList().Count()) % 2 == 0 ? false : true,
                              }).OrderByDescending(x => x.Date).ThenByDescending(x => x.Time.TimeOfDay).FirstOrDefault();

                var result2 = (from head in _context.HrmAtdMachineData.Where(e => e.FingerPrintId == EmployeeID).DefaultIfEmpty().AsEnumerable()
                               select new AttListDto()
                               {
                                   Date = head.Date,
                                   AttendenceType = head.IsIn == true ? "In" : "Out",
                                   Time = DateTime.ParseExact(String.Format("{0:dd/MM/yyyy h:mm:ss tt}", head.Time), "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                                   AttDateANDTime = String.Format("{0:dd/MM/yyyy h:mm:ss tt}", head.Time),
                                   SLNO = 0
                               }).Where(p => p.Date == DateTime.Today).OrderByDescending(x => x.Date).ThenByDescending(x => x.Time.TimeOfDay).ToList();
                int counter = 1;
                result2.ForEach(x => x.SLNO = counter++);
                //foreach (var item in result2)
                //{
                //    item.SLNO = counter++;
                //    if(counter % 2 == 0)
                //    {
                //        item.AttendenceType = "In";
                //    }
                //    else
                //    {
                //        item.AttendenceType = "Out";
                //    }
                //    datalist.Add(item);
                //}
                result.AttendenceList = result2;
                return result;
            }

            else
            {
                result.inTime = true;
                result.outTime = false;
                result.AttendenceList = new List<AttListDto>();
                return result;
            }
        }

        [Obsolete]
        public IEnumerable<EmployeeJobCard> EmployeeJobCard(string FromDate, string ToDate, string EmployeeID)
        {
            string[] SplitFromDate = FromDate.Split('/');
            string ConvertFromDate = SplitFromDate[2] + "-" + SplitFromDate[1] + "-" + SplitFromDate[0];

            string[] SplitToDate = ToDate.Split('/');
            string ConvertToDate = SplitToDate[2] + "-" + SplitToDate[1] + "-" + SplitToDate[0];

            var result = (IEnumerable<EmployeeJobCard>)_context.EmployeeJobCard.FromSqlRaw<EmployeeJobCard>("Execute dbo.prc_EmployeeAttendenceySummery @StartDateTime = {0}, @EndDateTime = {1}, @EmployeeID = {2}", ConvertFromDate, ConvertToDate, EmployeeID).ToList();

            return result;
        }

        [Obsolete]
        public ResponseModel LeaveApply(LeaveApplicationEntryDto Model)
        {
            ResponseModel response = new ResponseModel();
            var IsExist = _context.HrmLeaveApplicationEntry.FirstOrDefault(x => x.LeaveAppEntryId == Model.LeaveAppEntryId);
            var IsApplicable = _context.IsLeaveExist.FromSqlRaw<IsLeaveExist>("Execute dbo.Prc_SingelEmployeeLeaveBalaceStatus @EmployeeID = {0}, @LeaveType = {1}, @NoOfDay = {2}", Model.EmployeeID, Model.LeaveTypeId, Model.NoOfDay).AsEnumerable().FirstOrDefault();
            if(IsExist == null)
            {
                if (IsApplicable.status == "Yes")
                {
                    string LoginEmployeeID = Model.EmployeeID;
                    var MaxID = _context.customID.FromSqlRaw<CustomID>("Select ISNULL(MAX(CAST(LeaveAppEntryId AS int)),1)+1 as Code from HRM_LeaveApplicationEntry").FirstOrDefault();
                    Model.LeaveAppEntryId = MaxID.Code.ToString();
                    var Leaveid = SaveInfo(Model);

                    var empInfo = _context.HrmEmployee.Where(x => x.EmployeeId == Model.EmployeeID).FirstOrDefault();

                    foreach (var day in Model.LeaveDaysList)
                    {
                        DateTime dateCon = new DateTime();
                        dateCon = DateTime.ParseExact(day, "MM/dd/yyyy", null);

                        HrmLeaveApplicationDays leaveDays = new HrmLeaveApplicationDays();
                        leaveDays.LeaveAppEntryId = Model.LeaveAppEntryId;
                        leaveDays.Days = dateCon;
                        SaveLeaveDaysInfo(leaveDays, LoginEmployeeID);
                    }
                    string p = "<div class='card'>< img src = '' alt = '' style = '' >< div class='container'> <h4><b>John Doe</b></h4> <p>Architect & Engineer</p> </div></div>";

                    var t = _context.HrmAtdLeaveType.Where(x => x.LeaveTypeId == Model.LeaveTypeId).FirstOrDefault();
                    LeaveInfoMail Leavemodels = new LeaveInfoMail();
                    Leavemodels.EmployeeNAme = empInfo.FirstName + " " + empInfo.LastName;
                    Leavemodels.Messege = "This is " + empInfo.FirstName + " " + empInfo.LastName + " I want to take leave from " + Model.StartDate + " to " + Model.EndDate;
                    Leavemodels.TotalDayes = Model.NoOfDay.ToString();
                    Leavemodels.DateFrom = Model.StartDate;
                    Leavemodels.DateTo = Model.EndDate;
                    Leavemodels.LeaveFormat = Model.ApplyLeaveFormat == "FullLeave" ? "Full Leave" : "Short Leave";
                    Leavemodels.LeaveType = t.Name;
                    Leavemodels.Reason = Model.Reason;
                    Leavemodels.LinkID = Leaveid.LeaveAppEntryId;
                    Leavemodels.ShortLeaveFrom = Model.ShortLeaveFrom;
                    Leavemodels.ShortLeaveTo = Model.ShortLeaveTo;
                    Leavemodels.TotalTime = Model.ShortLeaveTime;
                    Leavemodels.FormatString = p;

                    SendMail(Leavemodels);
                    response.success = true;
                    response.message = "Successfully Leave applied.";
                    return response;
                }
                else
                {
                    response.success = true;
                    response.message = "Something Went Wrong. Please Try Again!";
                    return response;
                }
            }
            else
            {
                if (IsExist.HrapprovalStatus == "Pending")
                {
                    string LoginEmployeeID = Model.EmployeeID;
                    UpdateInfo(Model.LeaveAppEntryId, Model);
                    DeleteExistInfo(Model.LeaveAppEntryId);
                    foreach (var day in Model.LeaveDaysList)
                    {
                        DateTime dateCon = new DateTime();
                        dateCon = DateTime.ParseExact(day, "MM/dd/yyyy", null);

                        HrmLeaveApplicationDays leaveDays = new HrmLeaveApplicationDays();
                        leaveDays.LeaveAppEntryId = Model.LeaveAppEntryId;
                        leaveDays.Days = dateCon;
                        SaveLeaveDaysInfo(leaveDays, LoginEmployeeID);
                    }
                    response.success = true;
                    response.message = "Successfully Leave Updated.";
                    return response;
                }
                else
                {
                    response.success = false;
                    response.message = "You can't update this application! This application already " + IsExist.HrapprovalStatus;
                    return response;
                }
            }
            
        }
        public bool DeleteExistInfo(string LeaveID)
        {
            var result = _context.HrmLeaveApplicationDays.Where(x => x.LeaveAppEntryId == LeaveID).ToList();
            if (result != null)
            {
                _context.HrmLeaveApplicationDays.RemoveRange(_context.HrmLeaveApplicationDays.Where(c => c.LeaveAppEntryId == LeaveID));
                //context.HRM_LeaveApplicationDays.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateInfo(string id, LeaveApplicationEntryDto model)
        {
            var result = _context.HrmLeaveApplicationEntry.FirstOrDefault(x => x.LeaveAppEntryId == model.LeaveAppEntryId);
            if (result != null)
            {
                DateTime StartDate = new DateTime();
                StartDate = DateTime.ParseExact(model.StartDate, "dd/MM/yyyy", null);

                DateTime EndDate = new DateTime();
                EndDate = DateTime.ParseExact(model.EndDate, "dd/MM/yyyy", null);

                result.EmployeeId = model.EmployeeID;
                result.BossEmpAutoId = model.BossEmpAutoId;
                result.Hod = model.HOD;
                result.ApplyLeaveFormat = model.ApplyLeaveFormat;
                result.LeaveTypeId = model.LeaveTypeId;
                result.StartDate = StartDate;
                result.EndDate = EndDate;
                result.NoOfDay = Convert.ToDecimal(model.NoOfDay);
                result.Reason = model.Reason;
                result.ModifyDate = DateTime.Now;
                if (model.ApplyLeaveFormat == "ShortLeave")
                {
                    string TodayDate = DateTime.Now.ToString("yyyy-MM-dd");
                    TimeSpan spanEndTIme = DateTime.ParseExact(model.ShortLeaveFrom,
                                        "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
                    DateTime fromtime = Convert.ToDateTime(TodayDate + " " + spanEndTIme);

                    TimeSpan spanEndTIme2 = DateTime.ParseExact(model.ShortLeaveTime,
                                            "hh:mm", CultureInfo.InvariantCulture).TimeOfDay;
                    result.ShortLeaveFrom = fromtime;
                    result.ShortLeaveTo = fromtime;
                    result.ShortLeaveTime = spanEndTIme2;
                }

            }
            _context.SaveChanges();
            return true;
        }

        public void SendMail(LeaveInfoMail model)
        {
            if (model != null)
            {
                var BodyHtml = model.Messege;
                MailMessage mail = new MailMessage();
                mail.To.Add(new MailAddress("tawfiq_islam@yahoo.com"));
                mail.From = new MailAddress("gctlproject@gmail.com");
                //mail.To.Add(new MailAddress("en.estiak@gmail.com"));
                //mail.From = new MailAddress("eng.estiakahmed@gmail.com");

                mail.Subject = "Leave Application From " + model.EmployeeNAme;
                string Body = BodyHtml;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("gctlproject@gmail.com", "##Gctl12345##"); // Enter seders User name and password       
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            else
            {

            }
        }

        public void SaveLeaveDaysInfo(HrmLeaveApplicationDays model, string LoginEmployeeID)
        {
            _context.HrmLeaveApplicationDays.Add(model);
            _context.SaveChanges();
        }

        public HrmLeaveApplicationEntry SaveInfo(LeaveApplicationEntryDto model)
        {
            string TodayDate = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime StartDate = new DateTime();
            StartDate = DateTime.ParseExact(model.StartDate, "dd/MM/yyyy", null);

            DateTime EndDate = new DateTime();
            EndDate = DateTime.ParseExact(model.EndDate, "dd/MM/yyyy", null);

            HrmLeaveApplicationEntry coreCom = new HrmLeaveApplicationEntry();
            coreCom.LeaveAppEntryId = model.LeaveAppEntryId;
            coreCom.EmployeeId = model.EmployeeID;
            coreCom.LeaveTypeId = model.LeaveTypeId;
            coreCom.StartDate = StartDate;
            coreCom.EndDate = EndDate;
            coreCom.NoOfDay = Convert.ToDecimal(model.NoOfDay);
            coreCom.HalfDay = "N";
            coreCom.FirstOrSecondHalf = "";
            coreCom.Reason = model.Reason;
            coreCom.BossEmpAutoId = model.BossEmpAutoId;
            coreCom.Hod = model.HOD;
            coreCom.IsApproved = "";
            coreCom.ConfirmationRemarks = "";
            coreCom.CompanyCode = "001";
            coreCom.HodapprovalStatus = "";
            coreCom.HodapprovalRemarks = "";
            coreCom.HrapprovalStatus = "Pending";
            coreCom.HrapprovalRemarks = "";
            coreCom.ApplyLeaveFormat = model.ApplyLeaveFormat;
            coreCom.LeaveApplyProcess = "Manual";
            coreCom.Luser = model.EmployeeID;
            coreCom.Ldate = DateTime.Now;
            if (model.ApplyLeaveFormat == "ShortLeave")
            {
                TimeSpan spanEndTIme = DateTime.ParseExact(model.ShortLeaveFrom,
                                    "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
                DateTime fromtime = Convert.ToDateTime(TodayDate + " " + spanEndTIme);

                TimeSpan spanEndTIme2 = DateTime.ParseExact(model.ShortLeaveTime,
                                        "hh:mm", CultureInfo.InvariantCulture).TimeOfDay;
                coreCom.ShortLeaveFrom = fromtime;
                coreCom.ShortLeaveTo = fromtime;
                coreCom.ShortLeaveTime = spanEndTIme2;
            }
            _context.HrmLeaveApplicationEntry.Add(coreCom);
            _context.SaveChanges();
            return coreCom;
        }

        public List<ATDLeaveType> GetAllLeaveType()
        {
           var result = (from head in _context.HrmAtdLeaveType.AsEnumerable()
                      select new ATDLeaveType()
                      {
                          LeaveTypeId = head.LeaveTypeId,
                          Name = head.Name
                      }).ToList();

            return result;
        }

        public LeaveApplicationEntryDto GetLeaveInfo(string LeaveAppEntryId)
        {
            var result = (from psi in _context.HrmLeaveApplicationEntry
                          .Where(psi => psi.LeaveAppEntryId == LeaveAppEntryId).DefaultIfEmpty().AsEnumerable()
                          select new
                          {
                              LeaveAppEntryId = psi.LeaveAppEntryId,
                              EmployeeID = psi.EmployeeId,
                              BossEmpAutoId = psi.BossEmpAutoId,
                              HOD = psi.Hod,
                              ApplyLeaveFormat = psi.ApplyLeaveFormat,
                              LeaveTypeId = psi.LeaveTypeId,
                              StartDate = psi.StartDate,
                              NoOfDay = psi.NoOfDay,
                              EndDate = psi.EndDate,
                              ShortLeaveFrom = psi.ShortLeaveFrom,
                              ShortLeaveTime = psi.ShortLeaveTime == null ? null : DateTime.ParseExact(psi.ShortLeaveTime.ToString(), "hh:mm:ss", CultureInfo.InvariantCulture).TimeOfDay.ToString(),
                              ShortLeaveTO = psi.ShortLeaveTo,
                              Reason = psi.Reason
                          }).AsEnumerable().Select(a => new LeaveApplicationEntryDto()
                          {
                              LeaveAppEntryId = a.LeaveAppEntryId.ToString(),
                              EmployeeID = a.EmployeeID,
                              BossEmpAutoId = a.BossEmpAutoId,
                              HOD = a.HOD,

                              ApplyLeaveFormat = a.ApplyLeaveFormat,
                              LeaveTypeId = a.LeaveTypeId,
                              StartDate = ((DateTime)a.StartDate).ToString("dd/MM/yyyy"),
                              NoOfDay = a.NoOfDay,
                              EndDate = ((DateTime)a.EndDate).ToString("dd/MM/yyyy"),
                              ShortLeaveFrom = a.ShortLeaveFrom == null ? null : ((DateTime)(a.ShortLeaveFrom)).ToString("hh:mm:ss tt"),
                              ShortLeaveTime = a.ShortLeaveTime,
                              ShortLeaveTo = a.ShortLeaveTO == null ? null : ((DateTime)(a.ShortLeaveTO)).ToString("hh:mm:ss tt"),
                              Reason = a.Reason
                          }).FirstOrDefault();

            return result;
        }

        [Obsolete]
        public List<LeaveBalanceStatus> GetEmployeeLeaveStatus(string EmployeeID)
        {
            var balance = (List<LeaveBalanceStatus>)_context.LeaveBalanceStatus.FromSqlRaw<LeaveBalanceStatus>("Execute dbo.Prc_EmployeeLeaveBalaceStatus @EmployeeID = {0}", EmployeeID).ToList();
            return balance;
        }



        public List<ATD_Holiday> GetAllHolidayInfo()
        {
            var result = (from hol in _context.HrmAtdHoliday
                          join holtype in _context.HrmAtdHolidayType on hol.HolidayType equals holtype.HolidayType
                          into g
                          from d in g.DefaultIfEmpty()
                          select new
                          {
                              HolidayCode = hol.HolidayCode,
                              HolidayName = hol.HolidayName,
                              FromDate = hol.FromDate,
                              ToDate = hol.ToDate,
                              HolidayType = d.HolidayTypeName

                          }).AsEnumerable().Select(a => new ATD_Holiday()
                          {
                              //HolidayCode = a.HolidayCode,
                              //HolidayName = a.HolidayName,
                              FromDate = ((DateTime)a.FromDate).ToString("MM/dd/yyyy"),
                              ToDate = ((DateTime)a.ToDate).ToString("MM/dd/yyyy"),
                              //HolidayType = a.HolidayType
                          }).ToList();
            return result;
        }

        public CompannyWeekend CompannyWeekendList()
        {
            var result = (from mo in _context.HrmAtdCompanyWeekEnd
                        .DefaultIfEmpty()
                          select new
                          {
                              CompanyWeekEndCode = mo.CompanyWeekEndCode,
                              EffectiveDate = mo.EffectiveDate,
                              ApplyDate = mo.Ldate,
                              Weekend = mo.Weekend

        }).AsEnumerable().Select(a => new CompannyWeekend()
                          {
                              //CompanyWeekEndCode = a.CompanyWeekEndCode,
                              Weekend = a.Weekend.Split(',').ToList(),
                              EffectiveDate = ((DateTime)a.EffectiveDate).ToString("dd/MM/yyyy")
                          }).OrderBy(x=> x.EffectiveDate).FirstOrDefault();
            return result;
        }

        public void AddMachineData(HrmAtdMachineData hrmAtdMachineData)
        {
            if (hrmAtdMachineData.FingerPrintId == "")
            {
                throw new ArgumentNullException(nameof(hrmAtdMachineData.FingerPrintId));
            }

            if (hrmAtdMachineData == null)
            {
                throw new ArgumentNullException(nameof(hrmAtdMachineData));
            }

            if (_context.HrmAtdMachineData.Where(e => e.FingerPrintId == hrmAtdMachineData.FingerPrintId && e.Date == DateTime.Today).ToList().Count() != 0)
            {
                if ((_context.HrmAtdMachineData.Where(e => e.FingerPrintId == hrmAtdMachineData.FingerPrintId && e.Date == DateTime.Today).ToList().Count()) % 2 == 0)
                {
                    hrmAtdMachineData.IsIn = true;
                }
                else
                {
                    hrmAtdMachineData.IsIn = false;
                }
            }
            else
            {
                hrmAtdMachineData.IsIn = true;
            }


            hrmAtdMachineData.MachineId = "9";
            hrmAtdMachineData.Date = DateTime.Today;
            hrmAtdMachineData.Time = DateTime.Now;
            
            _context.HrmAtdMachineData.Add(hrmAtdMachineData);
        }

        //public void DeleteSalesDaliveryLocation(SalesDeliveryLocation SalseDeliveryLocation)
        //{
        //    throw new NotImplementedException();
        //}

        //[Obsolete]
        //public CustomIDDaliveryLocation GetID()
        //{
        //    return _context.customIDDaliveryLocation.FromSqlRaw<CustomIDDaliveryLocation>("Select FORMAT(ISNULL(MAX(RIGHT(DeliveryLocationCode,6)),0)+1,'00000000') as DeliveryLocationCode from Sales_DeliveryLocation").FirstOrDefault();
        //}

        //public IEnumerable<SalesContactPerson> GetSalseContactPerson()
        //{
        //    return _context.SalesContactPerson.ToList<SalesContactPerson>();
        //}

        //public bool SalseDaliveryLocationExists(string salseDaliveryLocation)
        //{
        //    if (salseDaliveryLocation == "")
        //    {
        //        throw new ArgumentNullException(nameof(salseDaliveryLocation));
        //    }
        //    return _context.SalesDeliveryLocation.Any(a => a.LocationAddress == salseDaliveryLocation);
        //}

        //public bool Save()
        //{
        //    return (_context.SaveChanges() >= 0);
        //}

        //public void UpdateSalesDaliveryLocation(SalesDeliveryLocation SalseDeliveryLocation)
        //{
        //    var SalseDeliveryLocationexist = _context.SalesDeliveryLocation.Find(SalseDeliveryLocation.DeliveryLocationCode);

        //    if (SalseDeliveryLocationexist == null)
        //        throw new AppException("Sales Dalivery Location not found to Update!");

        //    // update SalseDeliveryLocation if it has changed
        //    if (!string.IsNullOrWhiteSpace(SalseDeliveryLocation.LocationAddress) && SalseDeliveryLocation.LocationAddress != SalseDeliveryLocationexist.LocationAddress)
        //    {
        //        // throw error if the new username is already taken
        //        if (_context.SalesDeliveryLocation.Any(x => x.LocationAddress == SalseDeliveryLocation.LocationAddress))
        //            throw new AppException("This Location Address " + SalseDeliveryLocation.LocationAddress + " is already taken");

        //        SalseDeliveryLocationexist.LocationAddress = SalseDeliveryLocation.LocationAddress;
        //        SalseDeliveryLocationexist.DeliveryLocationCode = SalseDeliveryLocation.DeliveryLocationCode;
        //        SalseDeliveryLocationexist.ContactPerson = SalseDeliveryLocation.ContactPerson;
        //        SalseDeliveryLocationexist.Phone = SalseDeliveryLocation.Phone;
        //        SalseDeliveryLocationexist.Email = SalseDeliveryLocation.Email;
        //        SalseDeliveryLocationexist.Designation = SalseDeliveryLocation.Designation;

        //    }

        //    // update user properties if provided
        //    // update user properties if provided
        //    if (string.IsNullOrWhiteSpace(SalseDeliveryLocation.LocationAddress))
        //        throw new AppException("Please Give Delivery Location!");

        //    if (string.IsNullOrWhiteSpace(SalseDeliveryLocation.DeliveryLocationCode))
        //        throw new AppException("This data not valid!");

        //    _context.SalesDeliveryLocation.Update(SalseDeliveryLocationexist);
        //    _context.SaveChanges();
        //}
    }
}
