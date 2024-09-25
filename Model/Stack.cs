//2024 Tock13: Group 1, Alfred Roos, Fadumo Jama, Rahaf Jomaa
using System;
using System.Collections;

namespace Calculator.Model
{
    /// <summary>
    /// MyStack is a wrapper class for System.Collection.Stack which handles the tokens in the Calculate algorithn.
    /// It is used so we easily can change the underlying datasctructure for holding hour tokens.
    /// </summary>
    public class MyStack<T>
    {

        private Stack<T> _stack;
        /// <summary>This method returns the count of the stack</summary>
        /// <returns>Returns the number of items in the stack as an int</returns>
        public int Count {  get { return _stack.Count; } }

        public MyStack()
        {
            _stack = new Stack<T>();
        }


        /// <summary>This function takes item and adds  it to the top of the stack</summary>
        /// <param name="item"> The item to be added to the stack of the ype defined when creating the stack object</param>
        public T Push(T item)
        {
            _stack.Push(item);
            return item;
        }

        /// <summary>This function removes and returns the top of the stack</summary>
        /// <returns>It returns the top of the stack of type T</returns>
        public T Pop()
        {
            return _stack.Pop();
        }
    }
}
