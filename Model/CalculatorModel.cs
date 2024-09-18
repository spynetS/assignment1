namespace Calculator
{
    public class CalculatorModel
    {
        /// <summary> turns the string input to a list of Tokens operators or operands </summary>
        /// <param name="input"> the input string </param>
        /// <returns> List of tokens </returns>
        private List<Token> GetTokens(string input)
        {
            List<Token> tokens = new List<Token>();
            foreach (string val in input.Split(" "))
            {
                if (val == "+")
                {
                    tokens.Add(new Operator("+", (float a, float b) => a + b));
                }
                else if (val == "-")
                {
                    tokens.Add(new Operator("-", (float a, float b) => a - b));
                }
                else if (val == "*")
                {
                    tokens.Add(new Operator("*", (float a, float b) => a * b));
                }
                else if (val == "/")
                {
                    tokens.Add(new Operator("/", (float a, float b) =>
                    {
                        if (b == 0) throw new DivideByZeroException();
                        return a / b;
                    }));
                }
                else if (val == "%")
                {
                    tokens.Add(new Operator("%", (float a, float b) => a % b));
                }
                else if (float.TryParse(val, out float floatNumber))
                {
                    tokens.Add(new Operand(floatNumber));
                }
                else{
                    throw new IOException(val + " is not a real token");
                }
            }
            return tokens;
        }
        /// <summary>
        /// calculates
        /// </summary>
        /// <param name="input"> The input which should be calculated </param>
        /// <returns> The result as float </returns>

        public float Calculate(string input)
        {
            // translate string input to tokens
            List<Token> tokens = GetTokens(input);
            // inisiate our stack
            Stack<Token> stack = new Stack<Token>();
            foreach (Token token in tokens)
            {
                // if the token is a operator pop 2 values of the
                // stack and the the operator calculation with them
                // and push the value to the stack
                // else push the token to the stack
                if (token is Operator)
                {
                    float b = ((Operand)stack.Pop()).value;
                    float a = ((Operand)stack.Pop()).value;
                    float ans = ((Operator)token).Calculate(a, b);
                    stack.Push(new Operand(ans));
                }
                else
                {
                    stack.Push(token);
                }
            }
            // return the top of the stack
            return ((Operand)stack.Pop()).value;
        }
    }
}
