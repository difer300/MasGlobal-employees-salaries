using System.Net;

namespace MasGlobal.EmployeesSalaries.Models.Api
{
    public class BaseApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
