using System;

// Generic Class: A class that can work with any type of data you choose.
// Generic Method: A method that can handle different types of data without needing to rewrite it.

class Box<T>
{
    private T _content;

    public void Add(T item)
    {
        _content = item;
    }

    public T Get()
    {
        return _content;
    }
}

class Program
{
    static void Main()
    {
        // Create a Box for integers
        Box<int> intBox = new Box<int>();
        intBox.Add(123);
        Console.WriteLine($"Integer inside box: {intBox.Get()}");

        // Create a Box for strings
        Box<string> stringBox = new Box<string>();
        stringBox.Add("Hello, World!");
        Console.WriteLine($"String inside box: {stringBox.Get()}");
    }
}
