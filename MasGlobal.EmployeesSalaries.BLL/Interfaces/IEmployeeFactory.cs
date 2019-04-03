using MasGlobal.EmployeesSalaries.Models;
using MasGlobal.EmployeesSalaries.Models.Dto;

namespace MasGlobal.EmployeesSalaries.BLL.Interfaces
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(EmployeeDto employeeDto);
    }
}
