using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Scrapping.AllPossibilities.Http
{
    public class RequestHelper
    {
        private readonly CookieContainer _cookieContainer = new CookieContainer();
        public async Task<string> SendRequestAsync(string url, string method = "GET", Dictionary<string, string> headers = null, bool useCookieContainer = false,
                                                                string payload = null, string proxy = null, int timeout = 10000, bool automaticDecompression = false)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

            if (!(WebRequest.Create(url) is HttpWebRequest request))
                return null;

            request.Method = method;
            request.Timeout = timeout;
            if (automaticDecompression) request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            if (proxy != null)
            {
                request.Proxy = new WebProxy(proxy.Split(':')[0], int.Parse(proxy.Split(':')[1]));
            }

            if (useCookieContainer)
            {
                request.CookieContainer = _cookieContainer;
            }

            string response;

            foreach (var header in headers ?? new Dictionary<string, string>())
            {
                switch (header.Key.ToLower())
                {
                    case "content-type":
                        request.ContentType = header.Value;
                        break;
                    case "connection":
                        request.Connection = header.Value;
                        break;
                    case "method":
                        request.Method = header.Value;
                        break;
                    case "keep-alive":
                        request.KeepAlive = bool.Parse(header.Value);
                        break;
                    case "accept":
                        request.Accept = header.Value;
                        break;
                    case "host":
                        request.Host = header.Value;
                        break;
                    case "referer":
                        request.Referer = $"{header.Value}/";
                        break;
                    case "user-agent":
                        request.UserAgent = header.Value;
                        break;
                    case "AllowAutoRedirect":
                        request.AllowAutoRedirect = bool.Parse(header.Value);
                        break;
                    default:
                        request.Headers.Add(header.Key, header.Value);
                        break;
                }
            }

            switch (method)
            {
                case "GET":
                {
                    using (var r = (HttpWebResponse)(await request.GetResponseAsync()))
                    {
                        using (var dataStream = r.GetResponseStream())
                        {
                            using (var buffer = new BufferedStream(dataStream))
                            {
                                using (var readerStream = new StreamReader(buffer))
                                {
                                    response = await readerStream.ReadToEndAsync();
                                }
                            }
                        }
                    }

                    return response;
                }

                case "POST":
                {
                    var data = Encoding.ASCII.GetBytes(payload);
                    request.ContentLength = payload.Length;
                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    using (var postResponse = (HttpWebResponse)request.GetResponse())
                    {
                        using (var responseStream = new StreamReader(postResponse.GetResponseStream()))
                        {
                            response = responseStream.ReadToEnd();
                        }
                    }

                    return response;
                }

                default:
                    return null;
            }
        }
    }
}
