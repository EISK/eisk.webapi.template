using Eisk.Domains.Employee;
using Eisk.DomainServices.IntegrationTests;
using Test.Core.TestBases;

namespace Eisk.DataServices.EntityFrameworkCore.IntegrationTests
{
    public class EmployeeDataServiceTests: DataServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDataServiceTests():base (new EmployeeDataService(new InMemoryDbContextFactory().CreateDbContext()), x => x.Id)
        {

        }

    }
}
