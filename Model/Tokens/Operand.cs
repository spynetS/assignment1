using System;

namespace Calculator.Model
{
    /// <summary>Operand is a token which holds and number</summary>
    public class Operand : Token
    {
        /// <summary>This is the float value of the operand</summary>
        public float value { get; set; }
        public Operand(float value)
            :base(value.ToString())
        {
            this.value = value;
        }

       
    }
}
