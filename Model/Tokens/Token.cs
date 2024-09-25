//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
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
            return value;
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

