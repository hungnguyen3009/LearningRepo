using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.LocationCreated
{
    public class LocationCreatedEvent : BaseEvent
    {
        public int LocationId { get; }
        public string StreetAddress { get;; }
        public string City { get; }
        public string State { get; }
        public string PostalCode { get; }

        public LocationCreatedEvent(
            int locationId,
            string streetAddress,
            string city,
            string state,
            string postalCode)
        {
            LocationId = locationId;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
    }
}
