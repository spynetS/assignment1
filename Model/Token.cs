public class Token
{
    public string strValue { get; set; }
    public Token() { }
    public Token(string strValue) { this.strValue = strValue; }
}


public class Operand : Token
{
    public float value { get; set; }

    public Operand(float value)
    {
        this.value = value;
        this.strValue = value.ToString();
    }
}



public class Operator : Token
{
    public Calculate calculate;

    public Operator(string strValue) : base(strValue)
    {
        calculate = new Calculate((float a, float b) => { return a; });
    }

    public Operator(string strValue, Calculate calc) : base(strValue)
    {
        calculate = new Calculate(calc);
    }

    public delegate float Calculate(float a, float b);
}
