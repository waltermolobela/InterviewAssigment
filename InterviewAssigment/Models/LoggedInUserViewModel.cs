using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class LoggedInUserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool IsStaff { get; set; }
        public bool IsSuperuser { get; set; }
    }
}