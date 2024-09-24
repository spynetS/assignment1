using System;
using System.Collections;

namespace Calculator.Model
{
    public class MyStack<T>
    {

        private Stack<T> _stack;


        public MyStack()
        {
            _stack = new Stack<T>();
        }


        public T Push(T item)
        {
            _stack.Push(item);
            return item;
        }

        public T Pop()
        {
            return _stack.Pop();
        }
    }
}
