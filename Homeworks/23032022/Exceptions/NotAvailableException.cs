using System;
using System.Collections.Generic;
using System.Text;

namespace _23032022.Exceptions
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message)
        {
        }
    }
}
