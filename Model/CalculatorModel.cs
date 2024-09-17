namespace Calculator
{
    public class CalculatorModel
    {
        float previusAnswer = 0;
        // 10 10 +
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
            List<Token> tokens = GetTokens(input);
            Stack<Token> stack = new Stack<Token>();
            foreach (Token token in tokens)
            {
                if (token is Operator)
                {
                    float b = ((Operand)stack.Pop()).value;
                    float a = ((Operand)stack.Pop()).value;
                    float ans = ((Operator)token).calculate(a, b);
                    stack.Push(new Operand(ans));
                }
                else
                {
                    stack.Push(token);
                }
            }
            return ((Operand)stack.Pop()).value;
        }
    }
}
