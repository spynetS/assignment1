namespace Calculator
{
	public class CalculatorViewConsole : CalculatorView
	{
		public void Home()
		{
			Console.Write(" > ");
		}
		public void ShowHelp(){
			Console.WriteLine("Exit to exit");
			Console.WriteLine("write reverse polish expresion then enter to get answer");
		}
		public string GetInput(){
			return Console.ReadLine();
		}

		public void ShowAnswer(float answer)
		{
			Console.WriteLine("Answer: "+answer);
      }
    }

	public interface CalculatorView
	{
		public void Home();
		public void ShowHelp();
		public string GetInput();
		public void ShowAnswer(float answer);
    }
}
