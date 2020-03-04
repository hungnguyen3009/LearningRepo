using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.EmployeeCreated
{
    public class EmployeeCreatedEvent : BaseEvent
    {
        public int EmployeeId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string JobTitle { get; }

        public EmployeeCreatedEvent(
            int employeeId,
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string jobTitle)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
        }
    }
}
