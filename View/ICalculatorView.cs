namespace Calculator.View
{

    public interface ICalculatorView
	{
		/**
		 *  <summary>This function is used to get a RPN expression from the user</summary>
		 *  <returns>RPN expression inform of a string</returns>
		 *  */
		public string GetInput();
		public void Exit();
		public void ShowAnswer(float answer);
        public void ShowException(Exception e);
	}
}
