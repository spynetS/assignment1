using System;

namespace Calculator.Model
{
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