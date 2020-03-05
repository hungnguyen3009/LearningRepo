using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CQRS_Learning.Core.Implementations
{
    public abstract class Entity : IDomainEventManager
    {
        /// <summary>
        /// The Id of the entity
        /// </summary>
        public virtual Guid Id { get; set; }

        private List<INotification> _domainEvents;
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void UpdateDomainEvent(INotification eventItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents.Remove(eventItem);
        }
    }
}
