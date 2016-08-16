using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using System.Threading;
using System.Xml;

namespace APITesting.Common
{
    public class HTTPHelper
    {
        public static int GetResponseCode(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpStatusCode status = response.StatusCode;
            return (int)status;
        }

        public static string HTTPGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.Write(responseFromServer);
            Thread.Sleep(60000);

          


            return responseFromServer;
        }

        public static string HTTPPost(string postUrl, string postBody, string username, string password, string contentType)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(postUrl);
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] bytesToWrite = encoding.GetBytes(postBody);

            request.Method = "POST";
            request.ContentLength = bytesToWrite.Length;
            request.ContentType = contentType;

            string authInfo = username + ":" + password;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            request.Headers["Authorization"] = "Basic " + authInfo;

            Stream newStream = request.GetRequestStream();
            newStream.Write(bytesToWrite, 0, bytesToWrite.Length);
            newStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            return responseFromServer;

        }

        public static async void HTTPPostNewUser(string postUrl, string id, string name, string password)
        {

            var responseString = await postUrl.PostUrlEncodedAsync(new { id=id,name=name,password=password }).ReceiveString();
        }
    }
}
