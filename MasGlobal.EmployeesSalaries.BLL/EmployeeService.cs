using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasGlobal.EmployeesSalaries.BLL.Interfaces;
using MasGlobal.EmployeesSalaries.Models;
using MasGlobal.EmployeesSalaries.Models.Api;
using MasGlobal_employees_salaries.DAL;
using MasGlobal_employees_salaries.DAL.Interfaces;

namespace MasGlobal.EmployeesSalaries.BLL
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApiHelper _apiHelper;
        private readonly IEmployeeFactory _employeeFactory;

        public EmployeeService(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
            _employeeFactory = new EmployeeFactory();
        }

        public EmployeeService()
        {
            _apiHelper = new ApiHelper(new HttpCallerHelper());
            _employeeFactory = new EmployeeFactory();
        }

        public Employee GetEmployee(int id)
        {
            var response = (GetEmployeesResponse)_apiHelper.GetEmployees();
            return _employeeFactory.CreateEmployee(response.Employees.FirstOrDefault(e => e.Id == id));
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var response = (GetEmployeesResponse)_apiHelper.GetEmployees();
            return response.Employees.Select(e => _employeeFactory.CreateEmployee(e)).ToList();
        }
    }
}
