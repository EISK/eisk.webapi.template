using Eisk.EFCore.Setup;
using Eisk.Domains.Entities;
using Eisk.Test.Core.TestBases;
using Eisk.Domains.TestData;
using Eisk.DataServices.EFCore.DataContext;
using System;
using Xunit;

namespace Eisk.DataServices.EFCore.IntegrationTests
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            var db = TestDbContextFactory.CreateSqlServerDbContext();
            DbContextDataInitializer.Initialize(db);
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }
        
    }

    public class EmployeeDataServiceTests: DataServiceBaseIntegrationTests<Employee, int>, IClassFixture<DatabaseFixture>
    {
        public EmployeeDataServiceTests(): base(new EmployeeDataService(TestDbContextFactory.CreateSqlServerDbContext()), x => x.Id, new EmployeeDataFactory())
        {
            
        }

    }
}
