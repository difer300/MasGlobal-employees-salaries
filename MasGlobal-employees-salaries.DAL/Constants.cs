using System;

namespace MasGlobal_employees_salaries.DAL
{
    public static class Constants
    {
        public const string EmployeesSalariesApiPath = @"api/Employees";
        public static readonly Uri MasGlobalApi = new Uri($"http://masglobaltestapi.azurewebsites.net/");
    }
}
