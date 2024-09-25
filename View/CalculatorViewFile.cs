//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
namespace Calculator.View
{
    /// <summary>This CalculatorView interacts with 2 files. It reads from an 'input file' and writes to a 'output file'</summary>
    public class CalculatorViewFile : ICalculatorView
    {
        private StreamReader reader;

        /// <summary>Creates the calculate view</summary>
        /// <param name="input" >the file to read the inputs from</param>
        /// <param name="output" >the file to write the answers to</param>
        public CalculatorViewFile(string input, string output) : base(){
            //clears utputfile
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
            return input == null?"":input;
        }

        public void ShowAnswer(float answer)
        {
            using(StreamWriter writer = File.AppendText("output.txt")){
                writer.WriteLine(answer.ToString());
            }
        }
        public void ShowException(Exception e){
            using(StreamWriter writer = File.AppendText("output.txt")){
                writer.WriteLine(e.Message);
            }
        }
    }
}
