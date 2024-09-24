namespace Calculator.Model
{

    public class CalculatorModel : ICalculatorModel
    {

        public List<Token> GetTokens(string input)
        {
            List<Token> tokens = new List<Token>();
            foreach (string value in input.Split(" "))
            {
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
            }
            return tokens;
        }

        public float Calculate(string input)
        {
            List<Token> tokens = GetTokens(input);
            MyStack<Token> myStack = new MyStack<Token>();

            foreach (Token token in tokens)
            {
                if (token is Operand)
                {
                    myStack.Push(token);
                }
                else if (token is Operator)
                {
                    float b = ((Operand)myStack.Pop()).value;
                    float a = ((Operand)myStack.Pop()).value;

                    
                    float result = ((Operator)token).Calculate(a, b);
                    myStack.Push(new Operand(result));
                }
            }

            return ((Operand)myStack.Pop()).value;
        }
    }

}
