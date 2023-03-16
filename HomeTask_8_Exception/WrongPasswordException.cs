using System;
namespace HomeTask_8_Exception
{
	public class WrongPasswordException : Exception
    {
        public WrongPasswordException() { }

        public WrongPasswordException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
