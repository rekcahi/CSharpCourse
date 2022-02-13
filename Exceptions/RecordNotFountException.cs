using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public sealed class RecordNotFountException:Exception
    {
        public RecordNotFountException(string message):base(message)
        {

        }


    }
}
