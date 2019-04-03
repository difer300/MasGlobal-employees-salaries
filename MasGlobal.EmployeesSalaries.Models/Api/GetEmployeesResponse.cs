using System.Collections.Generic;
using MasGlobal.EmployeesSalaries.Models.Dto;

namespace MasGlobal.EmployeesSalaries.Models.Api
{
    public class GetEmployeesResponse : BaseApiResponse
    {
        public IEnumerable<EmployeeDto> Employees { get; set; }
    }
}
