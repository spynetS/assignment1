//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
namespace Calculator.Model
{
    /// <summary>
    /// TokenFactory is a factory which creates different, tokens in the CreateToken method, based on the string provided.
    /// </summary>
    class TokenFactory
    {
        /// <summary>
        ///  Create token is a method that returns a token subclass bassed on type param.
        ///  </summary>
        ///  <param name='type' >
        ///  Type is the string value of the token it can be an operator [+,-,*,/,%] or an number 0...float.max. It will return an operator or and operand depending on the type.
        ///  </param>
        public static Token CreateToken(string type)
        {
            switch (type)
            {
                case "+":
                    return new SumOperator("+");
                case "-":
                    return new SubtractOperator("-");
                case "*":
                    return new MultiplyOperator("*");
                case "/":
                    return new DivideOperator("/");
                case "%":
                        return new ModulusOperator("%");

                default:
                    // check if the type is a number.
                    // if it is we return an operand
                    // otherwise we throw and exception
                    float fvalue;
                    if (float.TryParse(type, out fvalue))
                    {
                        return (new Operand(fvalue));
                    }
                    else
                    {
                        throw new InvalidTokenException("Exception: Invalid Token: "+type);
                    }
            }
        }
    }
}
