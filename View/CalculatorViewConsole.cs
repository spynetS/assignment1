namespace Calculator.View
{
    public class CalculatorViewConsole : ICalculatorView
    {
        public void Exit()
        {
            Console.WriteLine("Good bye!");
        }

        public string GetInput()
        {
            Console.Write("Write RPN expression: ");
            return Console.ReadLine();
        }

        public void ShowAnswer(float answer)
        {
            Console.WriteLine("Result: "+answer);
        }
        public void ShowException(Exception e){
            Console.WriteLine(e.Message);
        }

    }
}
