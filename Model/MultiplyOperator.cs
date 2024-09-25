using System;
namespace Calculator.Model
{
    ///<summary>
    ///This class multiplies two float values and return their product
    ///</summary>

    public class MultiplyOperator : Operator
	{
        public MultiplyOperator(string value) : base(value) { }
        public override float Calculate(Operand a, Operand b)
		{
			return a.value * b.value;
		}
	}
}
