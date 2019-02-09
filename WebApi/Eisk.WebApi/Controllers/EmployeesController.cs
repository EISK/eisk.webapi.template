using Microsoft.AspNetCore.Mvc;

namespace Eisk.WebApi.Controllers
{
    using Core.Controller;
    using Domains.Entities;
    using DomainServices;

    [Route("api/[controller]")]
    public class EmployeesController : DomainApiControllerBaseAsync<Employee,int>
    {
        public EmployeesController(EmployeeDomainService employeeDomainService):base(employeeDomainService)
        {
            
        }
    }
}
