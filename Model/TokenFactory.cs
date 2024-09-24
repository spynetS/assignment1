namespace Calculator.Model
{
    class TokenFactory
    {
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
                    float fvalue;
                    if (float.TryParse(type, out fvalue))
                    {
                        return (new Operand(fvalue));
                    }
                    else
                    {
                        throw new InvalidTokenException("Exception: Invalid Token: "+type);
                    }
                    break;
            }
        }
    }
}
