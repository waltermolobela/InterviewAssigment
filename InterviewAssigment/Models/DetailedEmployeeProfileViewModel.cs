using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class DetailedEmployeeProfileViewModel
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public string TaxNumber { get; set; }
        public string Email { get; set; }
        public string PersonalEmail { get; set; }
        public string GithubUser { get; set; }
        public string BirthDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string IdDocument { get; set; }
        public string VisaDocument { get; set; }
        public string IsEmployed { get; set; }
        public string IsForeigner { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int YearsWorked { get; set; }
        public int Age { get; set; }
        public string NextReview { get; set; }
        public int DaysToBirthday { get; set; }
        public string LeaveRemaining { get; set; }
        public User User { get; set; }
        public Position Position { get; set; }
        public List<EmployeeNextOfSkin> EmployeeNextOfSkin { get; set; }
        public List<EmployeeReview> EmployeeReview { get; set; }
    }
}