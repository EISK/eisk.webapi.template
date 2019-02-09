namespace Eisk.DomainServices.IntegrationTests.EFCore
{
    using Domains.Entities;
    using Eisk.DataServices.EFCore;
    using Eisk.EFCore.Setup;
    using Eisk.Test.Core.TestBases;

    public class EmployeeDomainServiceIntegrationTests:DomainServiceBaseIntegrationTests<Employee, int>
    {
        public EmployeeDomainServiceIntegrationTests() :
            base(new EmployeeDomainService(Factory_DataService()), x => x.Id)
        {
            
        }

        static EmployeeDataService Factory_DataService()
        {
            EmployeeDataService employeeDataService = new EmployeeDataService(TestDbContextFactory.CreateDbContext());

            return employeeDataService;
        }
    }
}
