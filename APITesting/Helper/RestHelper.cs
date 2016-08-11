using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace APITesting.Helper
{
    class RestHelper
    {
        Uri _apiUrl = new Uri("");
        

        // Executes provided Rest request and returns Rest response. To parse it to particular object, use response.Data
        public IRestResponse<T>Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient { BaseUrl = _apiUrl, CookieContainer = AuthHelper.CookieJar };
            var response = client.Execute<T>(request);

            if(response.ErrorException != null)
            {
                const string message = "Error retreiving response. Check inner detials for more info.";
                var restException = new ApplicationException(message, response.ErrorException);
                throw restException;
            }
            return response;
        }

        //Execute provided Rest request without type <T>.
        public IRestResponse ExecuteRequest(RestRequest request)
        {
            var client = new RestClient { BaseUrl = _apiUrl, CookieContainer = AuthHelper.CookieJar };
            var reponse = client.Execute(request);

            return reponse;
        }
    }
}
