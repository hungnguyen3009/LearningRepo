using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Commands.RemoveEmployeeFromLocation
{
    public class RemoveEmployeeFromLocationCommand : IRequest
    {
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
    }
}
