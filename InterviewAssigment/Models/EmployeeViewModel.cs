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
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string GithubUser { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int YearsWorked { get; set; }
        public int Age { get; set; }
        public int DaysToBirthday { get; set; }
    }
}