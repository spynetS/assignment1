namespace Calculator
{
    class CalculatorController
    {
        private ICalculatorView view;
        private ICalculatorModel model;

        public CalculatorController(ICalculatorView view, ICalculatorModel model){
            this.view = view;
            this.model = model;
        }
        public void Run(){
            while(true){
                // ask for input
                view.Home();
                // get input
                string input = view.GetInput();
                // if input is not empty calculate the input
                if(input != ""){
                    float ans = model.Calculate(input);
                    view.ShowAnswer(ans);
                }
                // if input is empty break loop
                else {break;}
            }
            // exit view
            view.Exit();
        }
    }
}
