using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Staff { get; set; }
    }
}