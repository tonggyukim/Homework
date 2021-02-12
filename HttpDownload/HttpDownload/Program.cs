using System;
using System.Net;
using System.IO;

namespace HttpDownload
{
    public class testDownload
    {
        static void Main(string[] args)
        {
            //synch method 
            //Console.WriteLine("Enter a Target URL: ");
            //string url = Console.ReadLine();
            //var httpRequestInfo = HttpWebRequest.CreateHttp(url);
            //var httpResponseInfo = httpRequestInfo.GetResponse() as HttpWebResponse;
            //var responseStream = httpResponseInfo.GetResponseStream();
            //string webPage = string.Empty;
            //using (var sr = new StreamReader(responseStream))
            //{
            //    webPage = sr.ReadToEnd();

            //}
            //Console.WriteLine(webPage);

            //async method
            Console.WriteLine("Enter a Target URL: ");
            string url = Console.ReadLine();
            var httpRequestInfo = HttpWebRequest.CreateHttp(url);
            var callback = new AsyncCallback(httpResponseAvailable);
            var ar = httpRequestInfo.BeginGetResponse(callback, httpRequestInfo);
            ar.AsyncWaitHandle.WaitOne();
        }
        private static void httpResponseAvailable(IAsyncResult ar)
        {
            try
            {


            var httpRequestInfo = ar.AsyncState as HttpWebRequest;
            var httpResponseInfo = httpRequestInfo.EndGetResponse(ar) as HttpWebResponse;
            var responseStream = httpResponseInfo.GetResponseStream();
            string webPage = string.Empty;
            using (var sr = new StreamReader(responseStream))
            {
                webPage = sr.ReadToEnd();
            }
            Console.WriteLine(webPage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
