using System;
namespace Calculator.Model
{
	public class MultiplyOperator : Operator
	{
        public MultiplyOperator(string value) : base(value) { }
        public override float Calculate(float a, float b) 
		{
			return a * b;
		}
	}
}