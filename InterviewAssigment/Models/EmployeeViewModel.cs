using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class EmployeeViewModel
    {
        public User User { get; set; }
        public Position Position { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Github_User { get; set; }
        public string Birth_Date { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int Years_Worked { get; set; }
        public int Age { get; set; }
        public int Days_To_Birthday { get; set; }
    }
}