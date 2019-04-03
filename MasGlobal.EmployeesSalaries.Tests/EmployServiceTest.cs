using AutoFixture;
using AutoFixture.AutoMoq;
using MasGlobal.EmployeesSalaries.BLL;
using MasGlobal.EmployeesSalaries.Models.Api;
using MasGlobal.EmployeesSalaries.Models.Dto;
using MasGlobal_employees_salaries.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Net;

namespace MasGlobal.EmployeesSalaries.Tests
{
    [TestClass]
    public class EmployServiceTest
    {
        private readonly EmployeeService _employeeService;
        private readonly Mock<IApiHelper> _apiHelper;
        private readonly IFixture _fixture;

        public EmployServiceTest()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _apiHelper = new Mock<IApiHelper>();
            _employeeService = new EmployeeService(_apiHelper.Object);
        }

        [TestMethod]
        public void GetEmployee_ValidIdExistingEmployee_ReturnEmployeeObject()
        {
            //arrange
            var employeeDto = _fixture.Create<EmployeeDto>();
            var baseApiResponse = new GetEmployeesResponse
            {
                StatusCode = HttpStatusCode.OK,
                Employees = new[] { employeeDto }
            };

            _apiHelper
                .Setup(x => x.GetEmployees())
                .Returns(baseApiResponse);

            //act
            var result = _employeeService.GetEmployee(employeeDto.Id);

            //assert
            Assert.AreEqual(employeeDto.Id, result.Id);
        }

        [TestMethod]
        public void GetEmployee_InvalidIdEmployee_ReturnNullEmployeeObject()
        {
            //arrange
            var employeeDto = _fixture.Create<EmployeeDto>();
            var invalidId = _fixture.Create<int>();
            var baseApiResponse = new GetEmployeesResponse
            {
                StatusCode = HttpStatusCode.OK,
                Employees = new[] { employeeDto }
            };

            _apiHelper
                .Setup(x => x.GetEmployees())
                .Returns(baseApiResponse);

            //act
            var result = _employeeService.GetEmployee(invalidId);

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetEmployees_ValidRequest_ReturnAllEmployeeObjects()
        {
            //arrange
            var baseApiResponse = _fixture.Create<GetEmployeesResponse>();

            _apiHelper
                .Setup(x => x.GetEmployees())
                .Returns(baseApiResponse);

            //act
            var result = _employeeService.GetEmployees();

            //assert
            Assert.AreEqual(baseApiResponse.Employees.Count(), result.Count());
        }

    }
}
