using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CQRS_Learning.Core;
using CQRS_Learning.Core.Implementations;
using CQRS_Learning.Events.EmployeeCreated;

namespace CQRS_Learning.Models
{
    public class Employee : Core.Implementations.Entity, IAggregateRoot
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string JobTitle { get; private set; }

        private Employee() { }

        public Employee(
            Guid aggregateId,
            int employeeId,
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string jobTitle)
        {
            Id = aggregateId;
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;

            AddDomainEvent(new EmployeeCreatedEvent(employeeId, firstName, lastName, dateOfBirth, jobTitle));
        }
    }
}
