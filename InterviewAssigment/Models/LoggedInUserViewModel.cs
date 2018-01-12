using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewAssigment.Models
{
    public class LoggedInUserViewModel : User
    {     
        public bool Is_Superuser { get; set; }
    }
}