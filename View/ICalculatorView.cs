namespace Calculator.View
{

    public interface ICalculatorView
	{
		///  <summary>This function is used to get a RPN expression from the user</summary>
		///  <returns>RPN expression inform of a string</returns>
		public string GetInput();
		///  <summary>This function is used to show the calculated answer to the user</summary>
		///  <param>the calculated float value to be showned</param>
		public void ShowAnswer(float answer);
		///  <summary>This function Shows exceptions caught by the controller</summary>
		///  <param>The exception that got cought by the controller</param>
        public void ShowException(Exception e);
		///  <summary>This function is used to tell the view that the programs should close</summary>
		public void Exit();
	}
}
