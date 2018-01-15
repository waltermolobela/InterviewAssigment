using InterviewAssigment.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace InterviewAssigment.Utils
{
    public class Rest
    {
        #region properties
        public string _token;
        private static RestClient client = new RestClient();
        private static string endPoint = System.Configuration.ConfigurationManager.AppSettings["url"];
        #endregion

        public Rest(string token)
        {
            _token = token;
        }

        public Rest(string username, string password)
        {
            _token = LoginUser(username, password);
        }

        #region public methods
        public LoggedInUserViewModel GetLoggedInUser()
        {
            var loggedInUser = new LoggedInUserViewModel();

            try
            {
                client.BaseUrl = new Uri(endPoint);
                var request = new RestRequest("api/user/me/", Method.GET);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", String.Format("Token {0}", _token));
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)               
                    loggedInUser = JsonConvert.DeserializeObject<LoggedInUserViewModel>(response.Content); 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return loggedInUser;
        }

        public List<EmployeeViewModel> GetEmployees()
        {
            var employees = new List<EmployeeViewModel>();

            try
            {
                client.BaseUrl = new Uri(endPoint);               
                var request = new RestRequest("api/employee/", Method.GET);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", String.Format("Token {0}", _token));
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);               

                if (response.StatusCode == HttpStatusCode.OK)
                    employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(response.Content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employees;
        }

        public DetailedEmployeeProfileViewModel GetDetailedEmployeeProfile()
        {
            var detailedEmployeeProfile = new DetailedEmployeeProfileViewModel();

            try
            {
                client.BaseUrl = new Uri(endPoint);
                var request = new RestRequest("api/employee/me/", Method.GET);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", String.Format("Token {0}", _token));
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    detailedEmployeeProfile = JsonConvert.DeserializeObject<DetailedEmployeeProfileViewModel>(response.Content);
                }                   
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return detailedEmployeeProfile;
        }
        #endregion

        #region private methods
       
        private string LoginUser(string userName, string password)
        {
            var token = string.Empty;

            try
            {
                client.BaseUrl = new Uri(endPoint);
                var request = new RestRequest("api-token-auth/", Method.POST);
                request.AddHeader("Accept", "application/json");
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(new { username = userName, password = password });

                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = (JObject)JsonConvert.DeserializeObject(response.Content);
                    token = result["token"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return token;
        }
        #endregion
    }
}