using Eisk.DataServices.EFCore;
using Eisk.Domains.Entities;
using Eisk.Domains.TestData;
using Eisk.EFCore.Setup;
using Eisk.Test.Core.TestBases;

namespace Eisk.DomainServices.ComponentTests.EFCore
{
    public class EmployeeDataServiceTestsWithSqlServer : DomainServiceBaseComponentTests<Employee, int>
    {
        public EmployeeDataServiceTestsWithSqlServer() :
            base(new EmployeeDomainService(Factory_DataService()), x => x.Id, new EmployeeDataFactory())
        {
            
        }

        static EmployeeDataService Factory_DataService()
        {
            EmployeeDataService employeeDataService = new EmployeeDataService(TestDbContextFactory.CreateInMemoryDbContext());

            return employeeDataService;
        }
    }
}
