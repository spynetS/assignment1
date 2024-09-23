using System;

namespace Calculator.Model
{
    public class CalculatorModel : ICalculatorModel
    {
        public List<Token> GetToken(string input)
        {
            List<Token> tockens = new List<Token>();
            foreach (string value in input.Split(" "))
            {
               
                switch (Operation)
                {
                    case "-":
                        tockens.Add(new Operator((float a, float b) => a - b));
                        break;
                    case "+":
                        tockens.Add(new Operator((float a, float b) => a + b));
                        break;
                    case "*":
                        tockens.Add(new Operator((float a, float b) => a * b));
                        break;
                    case "/":
                        tockens.Add((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a / b;
                        });
                        break;

                    case "%":
                        tockens.Add((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a % b;
                        });
                        break;

                    default:
                        float fvalue;
                        if (float.TryParse(value, out fvalue))
                        {
                            tockens.Add(new Operand(fvalue));
                        }
                        else
                        {
                            throw new InvalidTokenException();
                        }

                        break;


                }
            }
            Console.WriteLine(tockens);
        }
        public float Calculate(string input)
        {

        }
    }

}