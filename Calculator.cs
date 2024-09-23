namespace Calculator
{
	class Calculator
	{
		private static void Main(string[] args)
		{

			CalculatorController controller =
				new CalculatorController(new CalculatorViewFile(),
										 new CalculatorModel());

			controller.Run();
		}
	}
}
