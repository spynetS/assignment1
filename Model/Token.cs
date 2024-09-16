public class Token
{
	string strValue;
	public Token(){}
	public Token(string strValue) {this.strValue = strValue;}
}
public class Operand : Token{
	float value {get;set;}

	public Operand(float value)
	{
		this.value = value;
	}
}
public class Operator : Token{
	public Calculate calculate;
	public Operator(string strValue) : base(strValue){
		calculate = new Calculate((float a,float b) => {return a;});
	}
	public Operator(string strValue, Calculate calc) : base(strValue){
		calculate = new Calculate(calc);
	}
	public delegate float Calculate(float a,float b);
}
