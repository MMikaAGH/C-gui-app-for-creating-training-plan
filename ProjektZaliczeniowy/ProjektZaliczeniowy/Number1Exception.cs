using System;
using System.Runtime.Serialization;

namespace ProjektZaliczeniowy
{
    [Serializable]
    public class Number1Exception : Exception
    {
        public Number1Exception()
        {
        }

        public Number1Exception(string message) : base(message)
        {
        }

        public Number1Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Number1Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}