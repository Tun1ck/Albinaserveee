using System;
using System.Collections.Generic;
using System.Text;

namespace Shareds.Exceptions
{

    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions(string message) : base(message)
        {

        }
    }
}
