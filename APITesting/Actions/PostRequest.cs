using System.Net;
using Flurl.Http;

namespace APITesting.Actions
{
    class PostRequest
    {
        string responseString;
        public async void postRequest(string url)
        {
            var responseString = await url.PostUrlEncodedAsync(new { id = 4, name = "tom", password = "Tom" }).ReceiveString();
        }
        public async void getRequest(string url)
        {
             responseString = await url
            .GetStringAsync();
        }
        public string responseReturn()
        {
            return responseString;
        }
    }
}
