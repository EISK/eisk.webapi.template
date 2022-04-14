using Xunit;

namespace Eisk.DataServices.EFCore.IntegrationTests
{
    using Domains.Entities;
    using Test.Core.TestBases;
    using Domains.TestData;
    using Eisk.EFCore.Setup;

    public class EmployeeDataServiceTests: DataServiceBaseIntegrationTests<Employee, int>, IClassFixture<DatabaseFixture>
    {
        public EmployeeDataServiceTests(): base(new EmployeeDataService(TestDbContextFactory.CreateSqlServerDbContext()), x => x.Id, new EmployeeDataFactory())
        {
            
        }

    }
}
