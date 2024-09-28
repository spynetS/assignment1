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
}