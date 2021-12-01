using APIES.GctlDBEntities;
using APIES.Helper.ModelHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
