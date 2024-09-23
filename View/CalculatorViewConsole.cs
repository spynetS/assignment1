namespace Calculator
{
    public class CalculatorViewConsole : ICalculatorView
    {
        public void Exit()
        {
            Console.WriteLine("Good bye!");
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Home()
        {
            Console.Write("Write RPN expression: ");
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
