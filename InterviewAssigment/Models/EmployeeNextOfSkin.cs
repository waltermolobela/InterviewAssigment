using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class EmployeeNextOfSkin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string Physical_Address { get; set; }     
        public int Employee { get; set; }
    }
}