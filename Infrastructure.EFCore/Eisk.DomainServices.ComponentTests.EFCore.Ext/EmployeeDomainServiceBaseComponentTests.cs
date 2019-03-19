using System.Linq;
using System.Threading.Tasks;
using Eisk.Domains.Entities;
using Eisk.Test.Core.TestBases;
using Xunit;

namespace Eisk.DomainServices.ComponentTests.EFCore.Ext
{
    public abstract class EmployeeDomainServiceBaseIntegrationTests : DomainServiceBaseIntegrationTests<Employee, int>
    {
    
        protected EmployeeDomainServiceBaseIntegrationTests(EmployeeDomainService employeeDomainService) : 
        base(employeeDomainService, x => x.Id)
        {
            _employeeDomainService = employeeDomainService;
        }

        private readonly EmployeeDomainService _employeeDomainService;

    
        [Fact]
        public async Task GetByFirstName_ValidFirstNamePassed_ShouldBeFoundInQuery()
        {
            //Arrange
            var firstName = "John";
            var objectToAdd = Factory_Entity(x => x.FirstName = firstName);
            await _employeeDomainService.Add(objectToAdd);

            //Act
            var returnEmployee = await _employeeDomainService.GetByFirstName(firstName);

            //Assert
            Assert.NotNull(returnEmployee);
            Assert.Equal(firstName, returnEmployee.FirstOrDefault()?.FirstName);
        }
    }
}
