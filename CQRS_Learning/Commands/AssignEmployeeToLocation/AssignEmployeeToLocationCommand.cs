using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Commands.AssignEmployeeToLocation
{
    public class AssignEmployeeToLocationCommand : IRequest
    {
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
    }
}
