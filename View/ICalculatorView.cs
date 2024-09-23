namespace Calculator
{

    public interface ICalculatorView
	{
		public void Home();
		public string GetInput();
		public void Exit();
		public void ShowAnswer(float answer);
        public void ShowException(Exception e);
	}
}
