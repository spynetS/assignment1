using System;

namespace Calculator
{
    public class Operand : Token
    {
        public float value { get; set; }
        public Operand(float value)
            :base(value.ToString())
        {
            this.value = value;
        }

       
    }
}
