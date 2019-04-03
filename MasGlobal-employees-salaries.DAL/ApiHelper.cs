using MasGlobal.EmployeesSalaries.Models.Api;
using MasGlobal_employees_salaries.DAL.Interfaces;
using System;

namespace MasGlobal_employees_salaries.DAL
{
    public class ApiHelper : IApiHelper
    {
        private readonly IHttpCallerHelper _httpCallerHelper;
        private readonly Uri _baseUri;

        public ApiHelper(IHttpCallerHelper httpCallerHelper)
        {
            _httpCallerHelper = httpCallerHelper;
            _baseUri = Constants.MasGlobalApi;
        }

        public BaseApiResponse GetEmployees()
        {
            var requestUri = new Uri(_baseUri, Constants.EmployeesSalariesApiPath);
            var response = _httpCallerHelper.Get(requestUri);

            var gatewayResponse = ResponseHelper.HttpWebResponseParserForUpload(response);
            return gatewayResponse;
        }

    }
}
