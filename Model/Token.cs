namespace Calculator.Model
{
    public abstract class Token
    {
        private string value = "";
        public override string ToString()
        {
            return base.ToString();
        }
        public Token(string value)
        {
            this.value= value;
        }

    }
}

