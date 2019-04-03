using System;
using System.Net;
using MasGlobal_employees_salaries.DAL.Interfaces;

namespace MasGlobal_employees_salaries.DAL
{
    public class HttpCallerHelper : IHttpCallerHelper
    {
        public HttpWebResponse Get(Uri uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            return (HttpWebResponse)request.GetResponse();
        }
    }
}
