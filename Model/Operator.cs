using System;
namespace Calculator.Model
{
    public class Operator:Token 
    {
        public delegate float CalculateHandler(float a, float b);

        private CalculateHandler calculateHandler;
        public Operator(CalculateHandler calculateHandler, string value)
            : base(value)
        {
            this.calculateHandler = calculateHandler;
        }

        public float Calculate (float a, float b)
        {
            return calculateHandler(a, b);
        }

    }
}



