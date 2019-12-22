using System;

namespace Lab6.Exceptions
{
    public class OperationNotAllowedException : Exception
    {
        public OperationNotAllowedException() : base() { }
        public OperationNotAllowedException(string message) : base(message) { }
        public OperationNotAllowedException(string message, Exception inner) : base(message, inner) { }
    }
}