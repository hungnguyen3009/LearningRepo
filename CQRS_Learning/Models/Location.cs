using CQRS_Learning.Core;
using CQRS_Learning.Core.Implementations;
using CQRS_Learning.Events.LocationCreated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Models
{
    public class Location : Entity, IAggregateRoot
    {
        public int LocationId { get; private set; }
        public string StreetAddress { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public List<int> Employees { get; private set; }

        private Location() { }

        public Location(
            Guid aggregateId,
            int locationId,
            string streetAddress,
            string city,
            string state,
            string postalCode)
        {
            Id = aggregateId;
            LocationId = locationId;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
            Employees = new List<int>();

            AddDomainEvent(new LocationCreatedEvent(locationId, streetAddress, city, state, postalCode));
        }

        public void AddEmployee(int employeeId)
        {
            Employees.Add(employeeId);

            // Event applied here
        }

        public void RemoveEmployee(int employeeId)
        {
            Employees.Remove(employeeId);

            // Event applied here
        }
    }
}
