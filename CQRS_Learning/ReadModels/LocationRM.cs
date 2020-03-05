using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.ReadModels
{
    public class LocationRM
    {
        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public List<int> Employees { get; set; }
        public Guid AggregateId { get; set; }

        public LocationRM()
        {
            Employees = new List<int>();
        }
    }
}
