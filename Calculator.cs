using Calculator.Model;
using Calculator.View;

namespace Calculator
{
	class Calculator
	{
		private static void Main(string[] args)
		{

			if(args.Length == 0){
				CalculatorController controller =
					new CalculatorController(new CalculatorViewConsole(),
											new CalculatorModel());
				controller.Run();
			}
			else{
				CalculatorController controller =
					new CalculatorController(new CalculatorViewFile(args[0],args[1]),
											new CalculatorModel());
				controller.Run();
			}

		}
	}
}
