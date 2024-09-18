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
    private CalculateHandler calculate;

    public Operator(string strValue) : base(strValue)
    {
    }

    public Operator(string strValue, CalculateHandler calc) : base(strValue)
    {
        calculate = new CalculateHandler(calc);
    }

    public delegate float CalculateHandler(float a, float b);
    public float Calculate(float a,float b){
        if(calculate != null){
            return calculate(a,b);
        }
        throw new Exception("Operator not set");
    }
}
