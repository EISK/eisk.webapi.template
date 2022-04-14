namespace Eisk.DataServices.EFCore.IntegrationTests
{
    using Domains.Entities;
    using Test.Core.TestBases;
    using Eisk.EFCore.Setup;
    using System.Threading.Tasks;

    public class EmployeeDataServiceTestsWithInMemoryDb : DataServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDataServiceTestsWithInMemoryDb() : base(new EmployeeDataService(TestDbContextFactory.CreateInMemoryDbContext()), x => x.Id)
        {

        }

        public override async Task Add_ValidDomainWithRandomIdPassed_ShouldThrowException()
        {
            await Task.Run(() => { 
                //no op method for in-memory
            });
        }

    }
}
