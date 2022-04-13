
namespace Eisk.DataServices.EFCore.IntegrationTests
{
    using Eisk.EFCore.Setup;
    using Domains.Entities;
    using Test.Core.TestBases;
    using Eisk.Domains.TestData;

    public class EmployeeDataServiceTests: DataServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDataServiceTests():base (new EmployeeDataService(TestDbContextFactory.CreateDbContext()), x => x.Id, new EmployeeDataFactory())
        {

        }

    }
}
