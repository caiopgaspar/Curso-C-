using System;

namespace ExerExcep.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {
            
        }
    }
}
