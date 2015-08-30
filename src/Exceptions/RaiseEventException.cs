using System;

namespace DomainNotificationHelper.Exceptions
{
    internal class RaiseEventException : Exception
    {
        public RaiseEventException()
        {
        }

        public RaiseEventException(string message)
            : base(message)
        {
        }

        public RaiseEventException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}