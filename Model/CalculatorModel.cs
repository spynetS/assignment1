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
            
        public float Calculate(string input)
        {
            List<Token> tokens = GetTokens(input);
            MyStack myStack = new MyStack(); 

            foreach (Token token in tokens)
            {
                if (token is Operand)
                {
                   
                    myStack.Push(((Operand)token).Value); 
                }
                else if (token is Operator)
                {
                    float b = (float)myStack.Pop(); 
                    float a = (float)myStack.Pop();

                    
                    float result = ((Operator)token).Calculate(a, b);
                    myStack.Push(result); 
                }
            }

            
            return (float)myStack.Pop();
        }
          
        }
    }

}
