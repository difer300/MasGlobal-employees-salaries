using System;
using System.Net;

namespace MasGlobal_employees_salaries.DAL.Interfaces
{
    public interface IHttpCallerHelper
    {
        HttpWebResponse Get(Uri uri);
    }
}
