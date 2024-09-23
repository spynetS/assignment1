using System;

namespace Calculator
{
    public class Operand : Token
    {
        public float value {get; set;}

        public Operand(float value){
            this.value = value;
        }
    }
}

