//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
namespace Calculator.View
{
    /// <summary>This CalculatorView interacts with the console. It reads from an standard in and writes to a standardout</summary>
    public class CalculatorViewConsole : ICalculatorView
    {
        public void Exit()
        {
            Console.WriteLine("Good bye!");
        }

        public string GetInput()
        {
            Console.Write("Write RPN expression: ");
            string? input = Console.ReadLine();
            return input == null?"":input;
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
