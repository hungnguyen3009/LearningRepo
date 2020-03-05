using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.EmployeeRemovedFromLocation
{
    public class EmployeeRemovedFromLocationEvent : BaseEvent
    {
        public int OldLocationId { get; }
        public int EmployeeId { get; }

        public EmployeeRemovedFromLocationEvent(
            int oldLocationId,
            int employeeId)
        {
            OldLocationId = oldLocationId;
            EmployeeId = employeeId;
        }
    }
}
