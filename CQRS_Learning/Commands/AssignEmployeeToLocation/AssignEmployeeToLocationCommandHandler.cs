using CQRS_Learning.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Learning.Commands.AssignEmployeeToLocation
{
    public class AssignEmployeeToLocationCommandHandler : IRequestHandler<AssignEmployeeToLocationCommand>
    {
        public async Task<Unit> Handle(AssignEmployeeToLocationCommand request, CancellationToken cancellationToken)
        {
            // Get location from LocationId
            // Add retrieved location to an employee

            return Unit.Value;
        }
    }
}
