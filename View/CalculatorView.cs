namespace Calculator
{

	public interface CalculatorView
	{
		public void Home();
		public void ShowHelp();
		public string GetInput();
		public void ShowAnswer(float answer);
	}

	public class CalculatorViewConsole : CalculatorView
	{
		public void Home()
		{
			Console.Write("Enter an RPN expression > ");
		}
		public void ShowHelp(){
			Console.WriteLine("empty to exit");
			Console.WriteLine("Help to help");
			Console.WriteLine("write rpn to get answer");
		}
		public string GetInput(){
			return Console.ReadLine();
		}

		public void ShowAnswer(float answer)
		{
			Console.WriteLine("Result: "+answer);
	  }
	}
}
