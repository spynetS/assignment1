using System;
namespace Calculator.Model
{
	public class SumOperator : Operator
    {
        public SumOperator(string value) : base(value) { }
        public override float Calculate(float a, float b) 
		{ 
			return a + b;
		}
	}
}