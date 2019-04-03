using System.Collections.Generic;
using MasGlobal.EmployeesSalaries.Models.Api;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using MasGlobal.EmployeesSalaries.Models.Dto;

namespace MasGlobal_employees_salaries.DAL
{
    public static class ResponseHelper
    {
        public static BaseApiResponse HttpWebResponseParserForUpload(HttpWebResponse responseApi)
        {
            var responseStream = responseApi?.GetResponseStream();
            var reader = new StreamReader(responseStream);
            var responseText = reader.ReadToEnd();
            var successResponse = new GetEmployeesResponse
            {
                Employees = JsonConvert.DeserializeObject<IEnumerable<EmployeeDto>>(responseText),
                StatusCode = HttpStatusCode.OK
            };

            return successResponse;
        }
    }
}
