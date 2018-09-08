using System;
using System.Runtime.Serialization;

namespace Cardsystem.Core
{
    [Serializable]
    internal class EntityNotExisted : Exception
    {
        public EntityNotExisted()
        {
        }

        public EntityNotExisted(string message) : base(message)
        {
        }

        public EntityNotExisted(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityNotExisted(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}