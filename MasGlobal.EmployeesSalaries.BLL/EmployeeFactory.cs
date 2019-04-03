using MasGlobal.EmployeesSalaries.BLL.Interfaces;
using MasGlobal.EmployeesSalaries.Models;
using MasGlobal.EmployeesSalaries.Models.Dto;
using MasGlobal.EmployeesSalaries.Models.Enum;

namespace MasGlobal.EmployeesSalaries.BLL
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(EmployeeDto employeeDto)
        {
            if (employeeDto == null) return null;

            Employee newEmployee = new Employee
            {
                Id = employeeDto.Id,
                RoleId = employeeDto.RoleId,
                Name = employeeDto.Name,
                RoleDescription = employeeDto.RoleDescription ?? "",
                RoleName = employeeDto.RoleName,

            };

            switch (employeeDto.ContractTypeName)
            {
                case ContractType.HourlySalaryEmployee:
                    newEmployee.Salary = employeeDto.HourlySalary;
                    newEmployee.AnnualSalary = employeeDto.HourlySalary * 12 * 120;
                    newEmployee.ContractType = Constants.HourlySalaryNameContract;
                    break;

                case ContractType.MonthlySalaryEmployee:
                    newEmployee.Salary = employeeDto.MonthlySalary;
                    newEmployee.AnnualSalary = employeeDto.MonthlySalary * 12;
                    newEmployee.ContractType = Constants.MonthlySalaryNameContract;
                    break;
            }

            return newEmployee;
        }
    }
}
