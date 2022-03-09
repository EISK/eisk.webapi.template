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
    public class EmployeesController : ControllerBase
    {
        EmployeeDomainService _employeeDomainService;
        public EmployeesController(EmployeeDomainService employeeDomainService)
        {
            _employeeDomainService = employeeDomainService;
        }

        [HttpGet(Name = "Employees")]
        public IEnumerable<Employee> Get()
        {
            return _employeeDomainService.GetAll().Result;
        }
    }
}
