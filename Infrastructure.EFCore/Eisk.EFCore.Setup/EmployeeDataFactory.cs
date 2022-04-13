using System;
using AutoFixture;
using Bogus;
using Eisk.Domains.Entities;
using Eisk.Domains.Enums;

namespace Eisk.Test.Core.DataGen
{
    public class EmployeeDataFactory:EntityDataFactory<Employee>
    {
        public override Employee Factory_Entity(Action<Employee> action = null, Action<Fixture> fixtureAction = null)
        {
            var employee = base.Factory_Entity(action, fixtureAction);

            var faker = new Faker();

            employee.Id = 0;
            employee.ReportsTo = null;
            employee.ReportsToId = null;
            employee.Subordinates = null;

            employee.TitleOfCourtesy = faker.PickRandom<TitleOfCourtesy>();
            employee.FirstName = faker.Person.FirstName;
            employee.LastName = faker.Person.LastName;
            employee.BirthDate = faker.Date.Past();

            var fakerAddress = faker.Address;
            employee.Address = new Domains.ValueObjects.Address
            {
                AddressLine = fakerAddress.StreetAddress(),
                City = fakerAddress.City(),
                PostalCode = fakerAddress.ZipCode(),
                Region = fakerAddress.State(),
                Country = fakerAddress.Country(),
            };

            employee.HireDate = faker.Date.Future();
            employee.Title = null;
            employee.Phone = faker.Person.Phone;
            employee.Extension = null;

            employee.Photo = null;
            employee.Notes = null;

            return employee;
        }
    }
}
