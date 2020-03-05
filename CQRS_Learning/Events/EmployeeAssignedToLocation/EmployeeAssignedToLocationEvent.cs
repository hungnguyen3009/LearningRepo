using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.EmployeeAssignedToLocation
{
    public class EmployeeAssignedToLocationEvent : BaseEvent
    {
        public int NewLocationId { get; }
        public int EmployeeId { get; }

        public EmployeeAssignedToLocationEvent(
            int newLocationId,
            int employeeId)
        {
            NewLocationId = newLocationId;
            EmployeeId = employeeId;
        }
    }
}
