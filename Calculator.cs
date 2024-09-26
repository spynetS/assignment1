//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
﻿using Calculator.Model;
using Calculator.View;
using Calculator.Controller;

namespace Calculator
{
	class Calculator
	{
		private static void Main(string[] args)
		{

			// if the number of arguments is 0 we create a controller with a console view
			// else if the number is 2 we create a controller with a file view
			if(args.Length == 0){
				CalculatorController controller =
					new CalculatorController(new CalculatorViewConsole(),
											new CalculatorModel());
				controller.Run();
			}
			else if(args.Length == 2){
				CalculatorController controller =
					new CalculatorController(new CalculatorViewFile(args[0],args[1]),
											new CalculatorModel());
				controller.Run();
			}
		}
	}
}
