using System;
namespace Calculator.Model
{
	public class SubtractOperator : Operator
	{
        public SubtractOperator(string value) : base(value) { }
        public override float Calculate (float a, float b)
		{
			return a - b;
		}
	}
}