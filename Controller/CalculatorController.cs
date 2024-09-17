namespace Calculator
{
    /// <summary>
    /// The controller for our prgram
    /// </summary>
    class CalculatorController
    {
        private CalculatorModel model;
        private CalculatorView view;

        public CalculatorController(CalculatorView view, CalculatorModel model)
        {
            this.view = view;
            this.model = model;
        }
        /// <summary>
        /// The main program loop
        /// </summary>
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
                    //calculate answer
                    try{
                        float answer = model.Calculate(input);
                        //show asnwer
                        view.ShowAnswer(answer);
                    }
                    catch(Exception e){
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}
