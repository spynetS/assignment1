using System;
using System.Collections.Generic;

namespace CalculatorModel
{
    public interface ICalculatorModel
    {

        List<Token> tokens ();
        Stack<Token> stack ();
      void  Calculate(string input);
    }
    
      
}


