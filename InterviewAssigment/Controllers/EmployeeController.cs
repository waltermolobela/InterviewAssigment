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
        // GET: Employee
        public ActionResult Index()
        {
            var token = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.Where(x => x.Type.Contains("UserToken")).FirstOrDefault().Value;
            var result = new Rest(token);  
            return View(result.GetEmployees());            
        }
    }
}