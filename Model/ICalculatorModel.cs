using System;
using System.Collections.Generic;

namespace Calculator.Model
{
    /// <summary>
    /// This interface is used by the controller 
    /// </summary>
    public interface ICalculatorModel
    {
        /// <summary>
        /// This method takes a RPN Expression as a string and after calculation returns a value as float
        /// </summary>
        /// <param name = "input"> input is an RPN expression </param>
        /// <return name > it returns the calculate value  as float </return>
        public float Calculate(string input);
    }
    
      
}


