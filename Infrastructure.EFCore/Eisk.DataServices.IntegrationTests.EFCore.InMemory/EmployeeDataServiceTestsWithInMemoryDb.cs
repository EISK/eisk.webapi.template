namespace Eisk.DataServices.IntegrationTests.EFCore.InMemory
{
    using Domains.Entities;
    using Test.Core.TestBases;
    using Eisk.EFCore.Setup;
    using Eisk.DataServices.EFCore;

    public class EmployeeDataServiceTestsWithInMemoryDb : DataServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDataServiceTestsWithInMemoryDb() : base(new EmployeeDataService(TestDbContextFactory.CreateInMemoryDbContext()), x => x.Id)
        {

        }

    }
}
