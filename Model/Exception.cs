using System;

namespace CalculatorModel
{
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
