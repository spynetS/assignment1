namespace Calculator
{

    public interface CalculatorView
	{
		public void Home();
		public void ShowHelp();
		public string GetInput();
		public void ShowAnswer(float answer);
	}
}
