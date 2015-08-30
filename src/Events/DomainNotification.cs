using System;
using DomainNotificationHelper.Events.Contracts;

namespace DomainNotificationHelper.Events
{
    public class DomainNotification : IDomainEvent
    {
        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
            Date = DateTime.Now;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime Date { get; }
    }
}