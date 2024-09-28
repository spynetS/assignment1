using System;

namespace Calculator.Model
{
    ///<summary>
    ///This class returns an exception when the operation is not (+,-,*,/,%)
    ///</summary>

    public class InvalidOperationException : Exception
    {
        public InvalidOperationException()
        {

        }

        public InvalidOperationException(string message)
        : base(message)
        {

        }

    }
}