using MasGlobal.EmployeesSalaries.BLL;
using MasGlobal.EmployeesSalaries.BLL.Interfaces;
using MasGlobal.EmployeesSalaries.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace MasGlobal.EmployeesSalaries.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
    }
}
