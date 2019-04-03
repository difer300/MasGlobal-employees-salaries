using MasGlobal.EmployeesSalaries.Models.Enum;

namespace MasGlobal.EmployeesSalaries.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractType { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double Salary { get; set; }
        public double AnnualSalary { get; set; }
    }
}
