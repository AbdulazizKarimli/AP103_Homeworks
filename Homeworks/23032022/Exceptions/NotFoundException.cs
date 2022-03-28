using System;
using System.Collections.Generic;
using System.Text;

namespace _23032022.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
