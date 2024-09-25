namespace Calculator.Model
{
    /// <summary>
    /// This is a base class that represent the Token in the calculator
    /// The token kan be  operator eller operand
    /// </summary>

    public abstract class Token
    {
        private string value = "";
        /// <summary>
        /// This function helps the token to return the value as string
        /// </summary>
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// A constructor that initials the token with a value
        /// </summary>
        public Token(string value)
        {
            this.value= value;
        }

    }
}

