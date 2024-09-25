//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
using System.ComponentModel.DataAnnotations;

namespace Calculator.Model
{
    /// <summary>
    /// This class is a superclass for all operators in the program.
    /// It inharits from Token but adds the calclate method.
    /// </summary>
    public abstract class Operator : Token 
    {
        public Operator(string value) : base(value) { }

        /// <summary>This function is used to calculate operands and returns the value. If not implemented by subclasses it will throw a NotImplementedException</summary>
        /// <param name="a">The first operand to be calculated with</param>
        /// <param name="b">The second operand to be calculated with</param>
        /// <returns>The calculated value from a and b defined by subclasses.</returns>
        public virtual float Calculate (Operand a, Operand b)
        {
            throw new NotImplementedException ();
        }

    }
}



