namespace Eisk.WebApi.Controllers
{
    using Eisk.Core.WebApi;
    using Domains.Entities;
    using DomainServices;

    public class EmployeesController : WebApiControllerBaseAsync<Employee,int>
    {
        public EmployeesController(EmployeeDomainService employeeDomainService):base(employeeDomainService)
        {
            
        }
    }
}
