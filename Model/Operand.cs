using System;

namespace Calculator
{
    public class Operand : Token
    {
        private float value;
        public Operand(float value){
            this.value = value;
        }
    }
}

