
namespace Calculator
{
    class CalculatorController
    {
        private CalculatorModel model = new CalculatorModel();
        private CalculatorView view;

        public CalculatorController(CalculatorView view)
        {
            this.view = view;
        }

        public void Run()
        {
            while (true)
            {
                // show views home
                view.Home();

                //gather input
                string input = view.GetInput();

                //handle input
                if (input == "exit") break;
                else if (input == "help") view.ShowHelp();
                else
                {
                    if (input == "+")
                    {
                        Operator sum = new Operator("asd",(float a, float b) => a+b);
                        Console.WriteLine(sum.calculate(1, 2));
                    }
                    //calculate answer
                    float answer = model.Calculate(input);

                    //show asnwer
                    view.ShowAnswer(answer);
                }
            }
        }
    }
}
