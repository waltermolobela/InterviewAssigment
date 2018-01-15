using InterviewAssigment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewAssigment.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private string _token;
        // GET: Employee
        public ActionResult Index()
        {         
            _token  = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.Where(x => x.Type.Contains("UserToken")).FirstOrDefault().Value;
            var result = new Rest(_token);  
            return View(result.GetEmployees());            
        }

        public ActionResult FullProfile()
        {
            _token = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.Where(x => x.Type.Contains("UserToken")).FirstOrDefault().Value;
            var result = new Rest(_token);
            return View(result.GetDetailedEmployeeProfile());
        }
    }
}