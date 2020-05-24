using System;
using System.Runtime.Serialization;

namespace Stiva
{
    [Serializable]
    internal class StivaGoalaExceptie : Exception
    {
        public StivaGoalaExceptie()
        {
        }

        public StivaGoalaExceptie(string message) : base(message)
        {
        }

        public StivaGoalaExceptie(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StivaGoalaExceptie(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}