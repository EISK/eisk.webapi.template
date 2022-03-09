namespace Eisk.WebApi.Controllers
{
    using Eisk.Core.WebApi;
    using Domains.Entities;
    using DomainServices;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using System;

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : WebApiControllerBase<Employee, int>
    {
        EmployeeDomainService _employeeDomainService;
        public EmployeesController(EmployeeDomainService employeeDomainService):base(employeeDomainService)
        {
            
        }
    }
}
