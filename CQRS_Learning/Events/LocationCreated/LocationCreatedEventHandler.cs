using AutoMapper;
using CQRS_Learning.ReadModels;
using CQRS_Learning.Repositories.Interfaces.Location;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Learning.Events.LocationCreated
{
    public class LocationCreatedEventHandler : INotificationHandler<LocationCreatedEvent>
    {
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepo;

        public LocationCreatedEventHandler(
            IMapper mapper,
            ILocationRepository locationRepo)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _locationRepo = locationRepo ?? throw new ArgumentNullException(nameof(locationRepo));
        }

        public async Task Handle(
            LocationCreatedEvent notification,
            CancellationToken cancellationToken)
        {
            LocationRM location = _mapper.Map<LocationRM>(notification);

            _locationRepo.Save(location);
        }
    }
}
