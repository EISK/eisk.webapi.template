using Microsoft.AspNetCore.Mvc;

namespace Eisk.WebApi.Controllers
{
    using Eisk.Core.WebApi;
    using Domains.Entities;
    using DomainServices;

    [Route("api/[controller]")]
    public class EmployeesController : WebApiControllerBaseAsync<Employee,int>
    {
        public EmployeesController(EmployeeDomainService employeeDomainService):base(employeeDomainService)
        {
            
        }
    }
}
