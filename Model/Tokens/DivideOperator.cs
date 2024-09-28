//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
﻿using System;
namespace Calculator.Model
{
	/// <summary>
	/// This class takes two float parameters and return their quotient
	/// </summary>
	public class DivideOperator : Operator
	{
        public DivideOperator(string value) : base(value) { }
        public override float Calculate(Operand a, Operand b)
		{
			if (b.value == 0)
			{
				throw new DivideByZeroException("Exception: Divide By Zero: " + a.value.ToString("0.00") + "/" + b.value.ToString("0.00"));
			}
			return a.value / b.value;
		}
	}
}
