using System;
namespace HomeTask_8_Exception
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() { }

        public WrongLoginException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
