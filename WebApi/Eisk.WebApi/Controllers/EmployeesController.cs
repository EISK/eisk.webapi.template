using System.Collections.Generic;
using System.Threading.Tasks;
using Eisk.Domains.Employee;
using Eisk.DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace Eisk.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private EmployeeDomainService _employeeDomainService;
        public EmployeesController(EmployeeDomainService ctx)
        {
            _employeeDomainService = ctx;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeDomainService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return await _employeeDomainService.GetById(id);
        }

        [HttpPost]
        public async Task Post(Employee employee)
        {
            await _employeeDomainService.Add(employee);
        }

        [HttpPut("{id}")]
        public async Task Put(int id, Employee employee)
        {
            await _employeeDomainService.Update(id, employee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeDomainService.Delete(id);
        }
    }
}
