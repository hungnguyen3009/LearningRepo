using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Core
{
    public interface IDomainEventManager
    {
        IReadOnlyCollection<INotification> DomainEvents { get; }

        void AddDomainEvent(INotification eventItem);
        void UpdateDomainEvent(INotification eventItem);
        void RemoveDomainEvent(INotification eventItem);
    }
}
