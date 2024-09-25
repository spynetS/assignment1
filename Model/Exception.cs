using System;

namespace Calculator.Model
{
    ///<summary>
    ///This class returns an exception when the denominator is zero or modulus by 0
    ///</summary>

    public class DivideByZeroException : Exception
    {

        public DivideByZeroException()

        {

        }

        public DivideByZeroException(string message)
            : base(message)
        {

        }

    }

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

    ///<summary>
    ///This class returns an exception when the operand is not a number 
    ///</summary>


    public class InvalidTokenException : Exception
    {
        public InvalidTokenException()
        {

        }
        public InvalidTokenException(string message)
        : base(message)
        {

        }

    }

}
