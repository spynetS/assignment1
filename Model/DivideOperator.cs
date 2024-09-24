﻿using System;
namespace Calculator.Model
{
	/// <summary>
	/// This class takes two float parameters and return their quotient
	/// </summary>
	public class DivideOperator : Operator
	{
        public DivideOperator(string value) : base(value) { }
        public override float Calculate(float a, float b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Exception: Divide By Zero: " + a + "/" + b);
			}
			return a / b;
		}
	}
}