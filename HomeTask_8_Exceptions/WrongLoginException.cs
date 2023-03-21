using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_8_Exceptions
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
