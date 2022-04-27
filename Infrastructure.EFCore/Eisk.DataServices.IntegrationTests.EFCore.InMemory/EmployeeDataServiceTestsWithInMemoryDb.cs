namespace Eisk.DataServices.IntegrationTests.EFCore.InMemory;

using Domains.Entities;
using Eisk.DataServices.EFCore;
using Eisk.EFCore.Setup;
using Test.Core.TestBases;

public class EmployeeDataServiceTestsWithInMemoryDb : DataServiceBaseIntegrationTests<Employee, int>
{
    public EmployeeDataServiceTestsWithInMemoryDb() : base(new EmployeeDataService(TestDbContextFactory.CreateInMemoryDbContext()), x => x.Id)
    {

    }

}
