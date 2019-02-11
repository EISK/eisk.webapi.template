namespace Eisk.DomainServices.IntegrationTests.EFCore.Ext
{
    using Eisk.DataServices.EFCore;
    using Eisk.EFCore.Setup;

    public class EmployeeDomainServiceIntegrationTests : EmployeeDomainServiceBaseIntegrationTests
    {
        public EmployeeDomainServiceIntegrationTests() :
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
