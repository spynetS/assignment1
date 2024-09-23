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
                string input;
                try{
                    input = view.GetInput();
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                    break;
                }
                // if input is not empty calculate the input
                if(input != ""){
                    try{
                        float ans = model.Calculate(input);
                        view.ShowAnswer(ans);
                    }
                    catch(Exception e){
                        view.ShowException(e);
                    }
                }
                // if input is empty break loop
                else {break;}
            }
            // exit view
            view.Exit();
        }
    }
}
