using Eisk.Domains.Employee;
using Test.Core.TestBases;
using Xunit;

namespace Eisk.DataServices.EntityFrameworkCore.IntegrationTests
{
    public class EmployeeDataServiceIntegrationTests:EntityTestBase<Employee>
    {
        #region Helpers

        private readonly EmployeeDataService _employeeDataService = Factory_DataService();

        static EmployeeDataService Factory_DataService()
        {
            var testDb = new TestDbContextFactory();

            EmployeeDataService employeeDataService = new EmployeeDataService(testDb.CreateDbContext());

            return employeeDataService;
        }

        #endregion

        [Fact]
        public void Add_1()
        {
            //Arrange
            var objectToAdd = Factory_Entity(x => x.Id = 0);

            //Act
            var testDb = new TestDbContextFactory();
            var returnEmployee = testDb.CreateDbContext().Employees.Add(objectToAdd);
            
        }

    }
}