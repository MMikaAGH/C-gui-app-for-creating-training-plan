using System;
using System.Runtime.Serialization;

namespace ProjektZaliczeniowy
{
    [Serializable]
    public class LetterException : Exception
    {
        public LetterException()
        {
        }

        public LetterException(string message) : base(message)
        {
        }

        public LetterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LetterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}