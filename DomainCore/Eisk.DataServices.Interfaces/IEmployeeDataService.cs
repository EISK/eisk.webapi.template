using System.Collections.Generic;
using Eisk.Core.DataService;
using System.Threading.Tasks;
using Eisk.Domains.Entities;

namespace Eisk.DataServices.Interfaces
{
    public interface IEmployeeDataService: IEntityDataServiceAsync<Employee>
    {
        Task<IList<Employee>> GetByFirstName(string firstName);

    }
}