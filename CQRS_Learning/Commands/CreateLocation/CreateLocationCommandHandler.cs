using CQRS_Learning.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Learning.Commands.CreateLocation
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        public async Task<Unit> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var location = new Location(
                request.LocationId,
                request.StreetAddress,
                request.City,
                request.State,
                request.PostalCode);

            return Unit.Value;
        }
    }
}
