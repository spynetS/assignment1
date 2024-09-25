//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
﻿namespace Calculator.Model
{
    /// <summary>
    ///This class handles all calculating logics 
    /// </summary>
    public class CalculatorModel : ICalculatorModel
    {
        /// <summary>
        /// This function returns a list of tokens based on the input 
        /// <param name = "string input "> RPN expression </param>
        /// <returns> list of operand and operators
        /// </summary>
        public List<Token> GetTokens(string input)
        {
            List<Token> tokens = new List<Token>();
            foreach (string value in input.Split(" "))
            {
                tokens.Add(TokenFactory.CreateToken(value));
            }
            return tokens;
        }
        /// <summary>
        /// This method takes a RPN Expression as a string and after calculation returns a value as float
        /// </summary>
        /// <param name = "input"> input is an RPN expression </param>
        /// <return name > it returns the calculate value  as float </return>
        public float Calculate(string input)
        {
            List<Token> tokens = GetTokens(input);
            MyStack<Token> myStack = new MyStack<Token>();

            foreach (Token token in tokens)
            {
                if (token is Operand)
                {
                    myStack.Push(token);
                }
                else if (token is Operator)
                {
                    if (myStack.Count < 2)
                    {
                        throw new InvalidOperationException("Exception: Invalid Operation:");
                    }
                    else
                    {
                        Operand b = (Operand)myStack.Pop();
                        Operand a = (Operand)myStack.Pop();


                        float result = ((Operator)token).Calculate(a, b);
                        myStack.Push(new Operand(result));
                    }
                }
            }

            return ((Operand)myStack.Pop()).value;
        }
    }

}
