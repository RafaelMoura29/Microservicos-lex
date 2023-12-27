using AwesomeShop.Services.Customers.Core.Events;
using System;
using System.Collections.Generic;

namespace AwesomeShop.Services.Customers.Core.Entities
{
    public class AggregateRoot : IEntityBase
    {
        public List<IDomainEvent> _events = new List<IDomainEvent>();
        public Guid Id { get; protected set; }

        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event)
        {
            if (@event == null)
                _events = new List<IDomainEvent>();

            _events.Add(@event);
        }
    }
}
