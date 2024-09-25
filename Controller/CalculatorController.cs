//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa

using Calculator.Model;
using Calculator.View;

namespace Calculator
{
    /// <summary>
    /// This is the calculator controller which handels the whole calculator.
    /// It asks the view for input tells the model to calculate the answer and then tells the view to show the answer.
    /// </summary>
    class CalculatorController
    {
        private ICalculatorView view;
        private ICalculatorModel model;

        /// <summary> This function is the main function </summary>
        /// <param name="view">This is the view the controller is going to use</param>
        /// <param name="model">This is the model the controller is going to use</param>
        public CalculatorController(ICalculatorView view, ICalculatorModel model){
            this.view = view;
            this.model = model;
        }
        /// <summary>
        /// This main function for the controller where the program lives.
        /// It will run untill the view returns an empty string or if the view's input gives and exception.
        /// </summary>
        public void Run(){
            while(true){
                // get input
                string input;
                try{
                    input = view.GetInput();
                }catch(Exception e){
                    view.ShowException(e);
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
