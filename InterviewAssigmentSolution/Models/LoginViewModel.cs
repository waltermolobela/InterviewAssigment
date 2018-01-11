using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace InterviewAssigmentSolution.Models
{
    public class LoginViewModel
    {
        #region Properties
        [Required(ErrorMessage = "Please provide a User Name")]
        [Display(Name = "Username")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Please provide a Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { get; set; }
        /// <summary>
        /// Indicates if the UserName should be remember for future logins
        /// </summary>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// List of roles saved in the cookie
        /// Needs to be Role otherwise the code will get confused with the Roles methods in role provider
        /// </summary>
        public List<string> Roles { get; set; }

        public string ErrorMessage { get; set; }
        #endregion
    }
}