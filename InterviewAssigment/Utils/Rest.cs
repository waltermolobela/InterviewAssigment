using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InterviewAssigment.Utils
{
    public class Rest
    {
        public string Get(string uri)
        {
            var result = RunAsync(uri).Result;
            //Validate(result, uri);
            return result;
        }

        private async Task<string> RunAsync(string uri)
        {
            try
            {
                return "";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}