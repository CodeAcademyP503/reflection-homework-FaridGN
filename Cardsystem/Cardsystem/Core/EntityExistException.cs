using System;
using System.Runtime.Serialization;

namespace Cardsystem.Core
{
    [Serializable]
    internal class EntityExistException : Exception
    {
        public EntityExistException()
        {
        }

        public EntityExistException(string message) : base(message)
        {
        }

        public EntityExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}