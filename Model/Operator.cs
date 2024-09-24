using System.ComponentModel.DataAnnotations;

namespace Calculator.Model
{
    public abstract class Operator : Token 
    {
        public Operator(string value) : base(value) { }

        public virtual float Calculate (float a, float b)
        {
            throw new NotImplementedException ();
            return 0;
        }

    }
}



