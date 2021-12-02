using System;
using System.Collections.Generic;
using System.Text;

namespace Shareds.Exceptions
{
    
        class NotFoundExceptions : Exception
        {
            public NotFoundExceptions(string message) : base(message)
            {

            }
        }
}
