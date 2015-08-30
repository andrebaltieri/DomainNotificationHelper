using System;
using System.Collections.Generic;
using DomainNotificationHelper.Events.Contracts;

namespace DomainNotificationHelper
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}