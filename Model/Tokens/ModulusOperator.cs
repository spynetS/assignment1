//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
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
                throw new DivideByZeroException("Exception: Modulu By Zero: "+ a.value.ToString("0.00") + "/" + b.value.ToString("0.00"));
            }
            return a.value % b.value;
        }
    }
}
