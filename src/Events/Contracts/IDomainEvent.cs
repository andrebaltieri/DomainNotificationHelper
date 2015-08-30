using System;

namespace DomainNotificationHelper.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime Date { get; }
    }
}