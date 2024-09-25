using System;
namespace Calculator.Model
{
	/// <summary>
	/// This class takes two float parameters and return their quotient
	/// </summary>
	public class DivideOperator : Operator
	{
        public DivideOperator(string value) : base(value) { }
        public override float Calculate(Operand a, Operand b)
		{
			if (b.value == 0)
			{
				throw new DivideByZeroException("Exception: Divide By Zero: " + a.value + "/" + b.value);
			}
			return a.value / b.value;
		}
	}
}
