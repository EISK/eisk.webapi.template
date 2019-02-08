using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eisk.Core.DataService.EFCore;
using Eisk.DataServices.EFCore.DataContext;
using Eisk.DataServices.Interfaces;
using Eisk.Domains.Employee;
using Microsoft.EntityFrameworkCore;

namespace Eisk.DataServices.EFCore
{
    public class EmployeeDataService : EntityDataServiceAsync<Employee>, IEmployeeDataService
    {
        public EmployeeDataService(AppDbContext dbContext) : base(dbContext)
        {

        }

        public virtual async Task<IList<Employee>> GetByFirstName(string firstName)
        {
            return await DbContext.Set<Employee>().Where(x => x.FirstName.Contains(firstName)).ToListAsync();
        }

    }
}