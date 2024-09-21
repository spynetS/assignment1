using System;
using System.Collections.Generic;

namespace CalculatorModel
{
    public interface ICalculatorModel
    {

        List<Token> Token ();
        Stack<Token> stack ();
      void  Calculate(string input);
    }
    
      
}


