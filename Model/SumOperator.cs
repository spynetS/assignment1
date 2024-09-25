using System;
namespace Calculator.Model
{
    ///<summary>
    ///This class adds two float values nd returns their sum
    ///</summary>

    public class SumOperator : Operator
    {
        public SumOperator(string value) : base(value) { }
        public override float Calculate(Operand a, Operand b)
		{ 
			return a.value + b.value;
		}
	}
}
