using System;

namespace Calculator
{
    public class CalculatorModel : ICalculatorModel
    {
        public List<Token> GetTokens(string input)
        {
            List<Token> tokens = new List<Token>();
            foreach (string value in input.Split(" "))
            {
                // Debuggar på detta viset
                // TODO Tabort denna console.wruiteliune
                Console.WriteLine("Read " + value);

                switch (value)
                {
                    case "-":
                        tokens.Add(new Operator((float a, float b) => a - b));
                        break;
                    case "+":
                        tokens.Add(new Operator((float a, float b) => a + b));
                        break;
                    case "*":
                        tokens.Add(new Operator((float a, float b) => a * b));
                        break;
                    case "/":
                        tokens.Add(new Operator((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a / b;
                        }));
                        break;

                    case "%":
                        tokens.Add(new Operator((float a, float b) =>
                        {
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return a % b;
                        }));
                        break;

                    default:
                        float fvalue;
                        if (float.TryParse(value, out fvalue))
                        {
                            tokens.Add(new Operand(fvalue));
                        }
                        else
                        {
                            throw new InvalidTokenException();
                        }
                        break;
                }
                Console.WriteLine("La till " + tokens[tokens.Count-1]);
            }
            Console.WriteLine(tokens);
            return tokens;
        }
        public float Calculate(string input)
        {
            List<Token> tokens = GetTokens(input);
            return 0;
        }
    }

}
