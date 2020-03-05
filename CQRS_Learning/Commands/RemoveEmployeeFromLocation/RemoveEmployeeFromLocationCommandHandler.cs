using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Learning.Commands.RemoveEmployeeFromLocation
{
    public class RemoveEmployeeFromLocationCommandHandler : IRequestHandler<RemoveEmployeeFromLocationCommand>
    {
        public async Task<Unit> Handle(RemoveEmployeeFromLocationCommand request, CancellationToken cancellationToken)
        {
            // Get location from LocationId
            // Remove retrieved location from an employee

            return Unit.Value;
        }
    }
}
