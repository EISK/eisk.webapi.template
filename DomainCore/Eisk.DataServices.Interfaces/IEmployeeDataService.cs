using Eisk.Domains.Employee;
using System.Collections.Generic;
using Eisk.Core.DataService;
using System.Threading.Tasks;

namespace Eisk.DataServices.Interfaces
{
    public interface IEmployeeDataService: IEntityDataServiceAsync<Employee>
    {
        Task<IList<Employee>> GetByFirstName(string firstName);

    }
}