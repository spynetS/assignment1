namespace Calculator
{
    public class CalculatorViewFile : ICalculatorView
    {
        private StreamReader reader;

        public CalculatorViewFile(){
            //clears outputfile
            using(StreamWriter writer = File.CreateText("output.txt")){
                writer.Write("");
            }
            reader = File.OpenText("input.txt");
        }

        public void Exit()
        {
            reader.Close();
        }

        public string GetInput()
        {
            string? input = reader.ReadLine();
            if(input == null)
                return "";
            return input;
        }

        public void Home()
        {
        }

        public void ShowAnswer(float answer)
        {
            using(StreamWriter writer = File.AppendText("output.txt")){
                writer.WriteLine(answer.ToString());
            }
        }
    }
}
