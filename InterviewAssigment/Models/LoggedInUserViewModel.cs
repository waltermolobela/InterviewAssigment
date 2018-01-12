using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class LoggedInUserViewModel : User
    {     
        public bool IsSuperuser { get; set; }
    }
}