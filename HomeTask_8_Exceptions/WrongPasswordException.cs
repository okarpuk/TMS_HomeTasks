using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_8_Exceptions
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException() { }

        public WrongPasswordException(string exceptionMessage) : base(exceptionMessage) { }
    }
}

