using System.Collections.Generic;
using System.Threading.Tasks;
using MasGlobal.EmployeesSalaries.Models;

namespace MasGlobal.EmployeesSalaries.BLL.Interfaces
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetEmployees();
    }
}
