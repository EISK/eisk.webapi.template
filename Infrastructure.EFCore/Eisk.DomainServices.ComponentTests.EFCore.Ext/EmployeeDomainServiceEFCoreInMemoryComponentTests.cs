using Eisk.DataServices.EFCore;
using Eisk.EFCore.Setup;

namespace Eisk.DomainServices.ComponentTests.EFCore.Ext
{
    public class EmployeeDomainServiceEfCoreInMemoryComponentTests : EmployeeDomainServiceBaseComponentTests
    {
        public EmployeeDomainServiceEfCoreInMemoryComponentTests() :
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
