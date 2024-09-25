using System;
namespace Calculator.Model
{
   /// <summary>
   /// This class subtract two float values and return their difference
   /// </summary>

    public class SubtractOperator : Operator
	{
        public SubtractOperator(string value) : base(value) { }
        public override float Calculate (Operand a, Operand b)
		{
			return a.value - b.value;
		}
	}
}
