using ApexAPI.Services;
using APIES.GctlDBEntities;
using APIES.Helper;
using APIES.Helper.ModelHelper;
using APIES.Models.Users;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APIES.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;


        public UsersController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
        //ResponseModel response = new ResponseModel();
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            
            var res = _mapper.Map<CoreUserInfoDto>(user);
            //var sc = _userService.GetSalesConcerns(res.SalesConcernId);
            var uu = _userService.getUser(res.EmployeeId);
            res.AppVersion = "1.0.1";
            res.FirstName = uu.FirstName;
            res.LastName = uu.LastName;
            res.Department = uu.Department;
            res.Designation = uu.Designation;
            return Ok(res);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            // map model to entity
            var user = _mapper.Map<CoreUserInfo>(model);

            try
            {
                // create user
                _userService.Create(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
        [Authorize(Roles = Role.Admin)]
        [HttpGet]      
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            var model = _mapper.Map<IList<UserModel>>(users);
            return Ok(model);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
                return Forbid();

            var user = _userService.GetById(id);
            var model = _mapper.Map<UserModel>(user);
            if (model == null)
                return NotFound();

            return Ok(model);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var user = _userService.GetById(id);
        //    var model = _mapper.Map<UserModel>(user);
        //    return Ok(model);
        //}

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateModel model)
        {
            // map model to entity and set id
            var user = _mapper.Map<CoreUserInfo>(model);
            user.Id = id;

            try
            {
                // update user 
                _userService.Update(user, model.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        //[AllowAnonymous]
        //[HttpGet("checkExistingDevice/{deviceid}")]
        //public ActionResult<ReturnConfirmation> CheckExistingDevice(string deviceid)
        //{
        //    ReturnConfirmation response = new ReturnConfirmation();
        //    //bool result = _userService.CheackValidity(deviceid);
        //    if (_userService.CheackValidity(deviceid) == true)
        //    {
        //        var userdevice = _userService.GetByDeviceID(deviceid);
        //        response.success = true;               
        //        response.message = "Device found!";
        //        response.status = userdevice.Status;
        //        response.UserID = userdevice.EmployeeId;
        //    }
        //    else
        //    {
        //        response.success = false;
        //        response.message = "Device not found!";
        //    }
        //    return response;
        //}

        //[AllowAnonymous]
        //[HttpPost("SendEmail")]
        //public ActionResult<ResponseModel> SendEmail([FromBody] EmailModel emailmodel)
        //{
        //    ResponseModel response = new ResponseModel();
        //    if (_userService.IsExistEmail(emailmodel.toemail) == true)
        //    {
        //        if (_userService.IsValidEmail(emailmodel.toemail) == true)
        //        {
        //            if (_userService.SendEmail(emailmodel.toemail) == true)
        //            {
        //                response.success = true;
        //                response.message = "Code Sent Successfully. Please check your email!";
        //            }
        //            else
        //            {
        //                response.success = false;
        //                response.message = "Code not sent successfully!";
        //            }
        //        }
        //        else
        //        {
        //            response.success = false;
        //            response.message = "This is not a valide email address!";
        //        }
        //    }
        //    else
        //    {
        //        response.success = false;
        //        response.message = "This email address not exist in database!";                
        //    }           
        //    return response;
        //}

        //[AllowAnonymous]
        //[HttpPost("addCoreUserDeviceInfo")]
        //public ActionResult<ReturnConfirmation> AddCoreUserDeviceInfo([FromBody] ConfirmDeviceIDandEmailModel confirmmodel)
        //{
        //    ReturnConfirmation response = new ReturnConfirmation();
        //    if(confirmmodel.ConfirmationCode != "")
        //    {
        //        if (confirmmodel.email != "")
        //        {
        //            if (confirmmodel.deviceID != "")
        //            {
        //                var user = _userService.GetByEmailandCode(confirmmodel.email,confirmmodel.ConfirmationCode);
        //                if(user != null)
        //                {
        //                    if (_userService.DeviceIDExists(confirmmodel.deviceID) != true)
        //                    {
        //                        var userID = user.EmployeeId;
        //                        CoreUserDevice core = new CoreUserDevice();
        //                        core.EmployeeId = userID;
        //                        core.DeviceId = confirmmodel.deviceID;

        //                        _userService.AddUserDevice(core);
        //                        _userService.Save();

        //                        response.success = true;
        //                        response.message = "Device information updated! Wait for approval.";
        //                        response.UserID = userID;
        //                        response.status = "Pending";
        //                    }
        //                    else
        //                    {
        //                        response.success = false;
        //                        response.message = "This Device Already Exist!";
        //                    }
                            
        //                }
        //                else
        //                {
        //                    response.success = false;
        //                    response.message = "You provide wrong confirmation code! Please check your email for confirmation code.";
        //                }
        //            }
        //            else
        //            {
        //                response.success = false;
        //                response.message = "No Device Found!";
        //            }
        //        }
        //        else
        //        {
        //            response.success = false;
        //            response.message = "No Device Found!";
        //        }
        //    }
        //    else
        //    {
        //        response.success = false;
        //        response.message = "Please provide Confirmation Code!";
        //    }

        //    return response;
        //}
       
    }
}
