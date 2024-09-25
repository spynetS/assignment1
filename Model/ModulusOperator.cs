﻿using System;
namespace Calculator.Model
{
    /// <summary>
    /// this class calculates the remainder of two floats values 
    /// </summary>
    public class ModulusOperator : Operator
    {
        public ModulusOperator(string value) : base(value) { }
        public override float Calculate(Operand a, Operand b)
        {
            if (b.value == 0)
            {
                throw new DivideByZeroException("Exception: Modulu By Zero: "+ a +"%"+ b);
            }
            return a.value % b.value;
        }
    }
}
