using System;
using System.Collections.Generic;
using System.Text;

namespace Scrapping.AllPossibilities.Http
{
    public class HeaderBuilder
    {
        public static Dictionary<string, string> GetDefaultHeaders()
        {
            return new Dictionary<string, string>()
            {
                {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36"},
                {"Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3" },
                {"Accept-Language", "en-US,en;q=0.9"},
            };
        }

        public static Dictionary<string, string> BuildOwnHeaders(HeaderModel headerModel)
        {
            var headers = new Dictionary<string, string>();

            if (headerModel.Accept  != null) headers.Add(nameof(headerModel.Accept ).Replace('_','-'), headerModel.Accept );
            if (headerModel.Accept_Charset  != null) headers.Add(nameof(headerModel.Accept_Charset ).Replace('_','-'), headerModel.Accept_Charset );
            if (headerModel.Accept_Encoding  != null) headers.Add(nameof(headerModel.Accept_Encoding ).Replace('_','-'), headerModel.Accept_Encoding );
            if (headerModel.Accept_Language  != null) headers.Add(nameof(headerModel.Accept_Language ).Replace('_','-'), headerModel.Accept_Language );
            if (headerModel.Accept_Datetime  != null) headers.Add(nameof(headerModel.Accept_Datetime ).Replace('_','-'), headerModel.Accept_Datetime );
            if (headerModel.Access_Control_Request_Method  != null) headers.Add(nameof(headerModel.Access_Control_Request_Method ).Replace('_','-'), headerModel.Access_Control_Request_Method );
            if (headerModel.Access_Control_Request_Headers  != null) headers.Add(nameof(headerModel.Access_Control_Request_Headers ).Replace('_','-'), headerModel.Access_Control_Request_Headers );
            if (headerModel.Authorization  != null) headers.Add(nameof(headerModel.Authorization ).Replace('_','-'), headerModel.Authorization );
            if (headerModel.Allow_Auto_Redirect  != null) headers.Add(nameof(headerModel.Allow_Auto_Redirect).Replace('_','-'), headerModel.Allow_Auto_Redirect);
            if (headerModel.Cache_Control  != null) headers.Add(nameof(headerModel.Cache_Control ).Replace('_','-'), headerModel.Cache_Control );
            if (headerModel.Connection  != null) headers.Add(nameof(headerModel.Connection ).Replace('_','-'), headerModel.Connection );
            if (headerModel.Content_Length  != null) headers.Add(nameof(headerModel.Content_Length ).Replace('_','-'), headerModel.Content_Length );
            if (headerModel.Content_Type  != null) headers.Add(nameof(headerModel.Content_Type ).Replace('_','-'), headerModel.Content_Type );
            if (headerModel.Cookie  != null) headers.Add(nameof(headerModel.Cookie ).Replace('_','-'), headerModel.Cookie );
            if (headerModel.Date  != null) headers.Add(nameof(headerModel.Date ).Replace('_','-'), headerModel.Date );
            if (headerModel.Expect  != null) headers.Add(nameof(headerModel.Expect ).Replace('_','-'), headerModel.Expect );
            if (headerModel.Forwarded  != null) headers.Add(nameof(headerModel.Forwarded ).Replace('_','-'), headerModel.Forwarded );
            if (headerModel.From  != null) headers.Add(nameof(headerModel.From ).Replace('_','-'), headerModel.From );
            if (headerModel.Host  != null) headers.Add(nameof(headerModel.Host ).Replace('_','-'), headerModel.Host );
            if (headerModel.IfMatch  != null) headers.Add(nameof(headerModel.IfMatch ).Replace('_','-'), headerModel.IfMatch );
            if (headerModel.IfModified_Since  != null) headers.Add(nameof(headerModel.IfModified_Since ).Replace('_','-'), headerModel.IfModified_Since );
            if (headerModel.If_None_Match  != null) headers.Add(nameof(headerModel.If_None_Match ).Replace('_','-'), headerModel.If_None_Match );
            if (headerModel.If_Range  != null) headers.Add(nameof(headerModel.If_Range ).Replace('_','-'), headerModel.If_Range );
            if (headerModel.If_Unmodified_Since  != null) headers.Add(nameof(headerModel.If_Unmodified_Since ).Replace('_','-'), headerModel.If_Unmodified_Since );
            if (headerModel.Max_Forwards  != null) headers.Add(nameof(headerModel.Max_Forwards ).Replace('_','-'), headerModel.Max_Forwards );
            if (headerModel.Origin  != null) headers.Add(nameof(headerModel.Origin ).Replace('_','-'), headerModel.Origin );
            if (headerModel.Pragma  != null) headers.Add(nameof(headerModel.Pragma ).Replace('_','-'), headerModel.Pragma );
            if (headerModel.Proxy_Authorization  != null) headers.Add(nameof(headerModel.Proxy_Authorization ).Replace('_','-'), headerModel.Proxy_Authorization );
            if (headerModel.Range  != null) headers.Add(nameof(headerModel.Range ).Replace('_','-'), headerModel.Range );
            if (headerModel.Referer  != null) headers.Add(nameof(headerModel.Referer ).Replace('_','-'), headerModel.Referer );
            if (headerModel.TE  != null) headers.Add(nameof(headerModel.TE ).Replace('_','-'), headerModel.TE );
            if (headerModel.User_Agent  != null) headers.Add(nameof(headerModel.User_Agent ).Replace('_','-'), headerModel.User_Agent );
            if (headerModel.Upgrade  != null) headers.Add(nameof(headerModel.Upgrade ).Replace('_','-'), headerModel.Upgrade );
            if (headerModel.Via  != null) headers.Add(nameof(headerModel.Via ).Replace('_','-'), headerModel.Via );
            if (headerModel.Warning != null) headers.Add(nameof(headerModel.Warning).Replace('_','-'), headerModel.Warning);

            return headers;
        }
    }
}
