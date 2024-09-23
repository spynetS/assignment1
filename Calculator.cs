﻿namespace Calculator
{
	class Calculator
	{
		private static void Main(string[] args)
		{

			CalculatorController controller =
				new CalculatorController(new CalculatorViewConsole(),
										 new CalculatorModel());

			controller.Run();
		}
	}
}
