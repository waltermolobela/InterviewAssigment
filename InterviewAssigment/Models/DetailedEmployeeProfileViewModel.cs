using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class DetailedEmployeeProfileViewModel
    {
        public int Id { get; set; }
        public string Id_Number { get; set; }
        public string Phone_Number { get; set; }
        public string Physical_Address { get; set; }
        public string Tax_Number { get; set; }
        public string Email { get; set; }
        public string Personal_Email { get; set; }
        public string Github_User { get; set; }
        public string Birth_Date { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Id_Document { get; set; }
        public string Visa_Document { get; set; }
        public string Is_Employed { get; set; }
        public string Is_Foreigner { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int Years_Worked { get; set; }
        public int Age { get; set; }
        public string Next_Review { get; set; }
        public int Days_To_Birthday { get; set; }
        public string Leave_Remaining { get; set; }
        public User User { get; set; }
        public Position Position { get; set; }
        public List<EmployeeNextOfSkin> EmployeeNextOfSkin { get; set; }
        public List<EmployeeReview> EmployeeReview { get; set; }
    }
}