using System;
using System.Collections;

public class MyStack
{
    // Attributet stack av typen System.Collections.Stack
    private Stack _stack;

    // Konstruktorn som matchar klassens namn MyStack
    public MyStack()
    {
        _stack = new Stack(); // Skapar en ny instans av System.Collections.Stack
    }

    // Push-metod som lägger ett objekt på stacken och returnerar objektet
    public object Push(object item)
    {
        _stack.Push(item); // Lägger till objektet i stacken
        return item;       // Returnerar det inskickade objektet
    }

    // Pop-metod som tar bort och returnerar det översta objektet från stacken
    // Om stacken är tom, returnerar den null istället för att kasta ett undantag
    public object Pop()
    {
        if (_stack.Count == 0)
        {
            return null; // Returnerar null om stacken är tom
        }
        return _stack.Pop(); // Tar bort och returnerar översta objektet från stacken
    }
}