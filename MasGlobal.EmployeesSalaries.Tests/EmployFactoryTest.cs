using AutoFixture;
using AutoFixture.AutoMoq;
using MasGlobal.EmployeesSalaries.BLL;
using MasGlobal.EmployeesSalaries.Models;
using MasGlobal.EmployeesSalaries.Models.Dto;
using MasGlobal.EmployeesSalaries.Models.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasGlobal.EmployeesSalaries.Tests
{
    [TestClass]
    public class EmployFactoryTest
    {
        private readonly EmployeeFactory _employeeFactory;
        private readonly IFixture _fixture;

        public EmployFactoryTest()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _employeeFactory = new EmployeeFactory();
        }

        [TestMethod]
        [DataRow(ContractType.HourlySalaryEmployee)]
        [DataRow(ContractType.MonthlySalaryEmployee)]
        public void CreateEmployee_ValidEmployeeDto_ReturnEmployeeObject(ContractType contractType)
        {
            //arrange
            var employeeDto = _fixture.Create<EmployeeDto>();
            employeeDto.ContractTypeName = contractType;

            //act
            var result = _employeeFactory.CreateEmployee(employeeDto);

            //assert
            Assert.IsInstanceOfType(result, typeof(Employee));
        }

        [TestMethod]
        public void CreateEmployee_NullEmployeeDto_ReturnNullEmployeeObject()
        {
            //arrange
            EmployeeDto employeeDto = null;

            //act
            var result = _employeeFactory.CreateEmployee(employeeDto);

            //assert
            Assert.IsNull(result);
        }
    }
}
