using System;
namespace CalculatorModel
{
    public delegate float CalculateHandler(float a, float b);
    public class Operator
    {
        private CalculateHandler calculateHandler;
        public Operator(string Operation)
        {
            switch (Operation)
            {
                case "-":
                    calculateHandler = new CalculateHandler((float a, float b) => a - b);
                    break;
                case "+":
                    calculateHandler = new CalculateHandler((float a, float b) => a + b);
                    break;
                case "*":
                    calculateHandler = new CalculateHandler((float a, float b) => a * b);
                    break;
                case "/":
                    try
                    {
                        calculateHandler = new CalculateHandler((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a / b;
                        });

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divide by zero is not allowed!");
                    }

                    break;

                case "%":
                    try
                    {
                        calculateHandler = new CalculateHandler((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a % b;
                        });

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Module by zero is not allowed!");
                    }


                    break;

                default:
                    try
                    {
                        if (Operation != "+" || Operation != "-" || Operation != "*" || Operation != "/" || Operation != "%")
                        {
                            throw new InvalidTokenException();
                        }
                    }
                    catch (InvalidTokenException)
                    {
                        Console.WriteLine("This is not an arthemitc operator.");
                    }
                    break;


            }
        }

    }
}


