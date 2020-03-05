using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.ReadModels
{
    // This class represents how Employees will be stored in RM database
    public class EmployeeRM
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        public int LocationId { get; set; }
        public Guid AggregateId { get; set; }
    }
}
