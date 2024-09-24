using System;
namespace Calculator.Model
{
    /// <summary>
    /// this class calculates the remainder of two floats values 
    /// </summary>
    public class ModulusOperator : Operator
    {
        public ModulusOperator(string value) : base(value) { }
        public override float Calculate(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Exception: Modulu By Zero: "+ a +"%"+ b);
            }
            return a % b;
        }
    }
}
