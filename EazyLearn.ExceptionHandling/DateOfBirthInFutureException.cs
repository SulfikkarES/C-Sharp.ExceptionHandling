using System;
using System.Runtime.Serialization;

namespace EazyLearn.ExceptionHandling
{
    [Serializable]
    internal class DateOfBirthInFutureException : Exception
    {
        public DateOfBirthInFutureException()
        {
        }

        public DateOfBirthInFutureException(string message) : base(message)
        {
        }

        public DateOfBirthInFutureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateOfBirthInFutureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}