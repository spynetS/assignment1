namespace Calculator.Model
{

    public class CalculatorModel : ICalculatorModel
    {

        public List<Token> GetTokens(string input)
        {
            List<Token> tokens = new List<Token>();
            foreach (string value in input.Split(" "))
            {
                tokens.Add(TokenFactory.CreateToken(value));
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
                    if (myStack.Count < 2)
                    {
                        throw new InvalidOperationException("Exception: Invalid Operation:");
                    }
                    else
                    {
                        float b = ((Operand)myStack.Pop()).value;
                        float a = ((Operand)myStack.Pop()).value;


                        float result = ((Operator)token).Calculate(a, b);
                        myStack.Push(new Operand(result));
                    }
                }
            }

            return ((Operand)myStack.Pop()).value;
        }
    }

}
