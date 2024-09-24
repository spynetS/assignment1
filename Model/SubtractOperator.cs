using System;
namespace Calculator.Model
{
   /// <summary>
   /// This class subtract two float values and return their difference
   /// </summary>

    public class SubtractOperator : Operator
	{
        public SubtractOperator(string value) : base(value) { }
        public override float Calculate (float a, float b)
		{
			return a - b;
		}
	}
}