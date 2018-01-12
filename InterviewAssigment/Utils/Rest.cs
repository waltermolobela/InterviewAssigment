﻿using InterviewAssigment.Models;
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
        private string _token;
        private static RestClient client = new RestClient();
        private static string endPoint = System.Configuration.ConfigurationManager.AppSettings["url"];
        #endregion

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

                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = (JObject)JsonConvert.DeserializeObject(response.Content);
                    loggedInUser.Email = result["email"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return loggedInUser;
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