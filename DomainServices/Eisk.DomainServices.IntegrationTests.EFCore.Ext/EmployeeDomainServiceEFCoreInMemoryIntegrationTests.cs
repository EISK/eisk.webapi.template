namespace Eisk.DomainServices.IntegrationTests.EFCore.Ext
{
    using Eisk.DataServices.EFCore;
    using Eisk.EFCore.Setup;

    public class EmployeeDomainServiceEfCoreInMemoryIntegrationTests : EmployeeDomainServiceBaseIntegrationTests
    {
        public EmployeeDomainServiceEfCoreInMemoryIntegrationTests() :
            base(new EmployeeDomainService(Factory_DataService()))
        {
            
        }

        static EmployeeDataService Factory_DataService()
        {
            EmployeeDataService employeeDataService = new EmployeeDataService(TestDbContextFactory.CreateDbContext());

            return employeeDataService;
        }
    }
}
