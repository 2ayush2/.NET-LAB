using System;
using System.Collections.Generic;
using System.Linq;

// LINQ (Language Integrated Query): A way to easily search and work with lists of data.
// Using a Method as a Condition: Filtering the list using a method to decide what to include.

class NumberUtils
{
    // Method to check if a number is even // Method to check if a number is even
    public static bool IsEven(int number) => number % 2 == 0;
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Find even numbers using LINQ and the IsEven method
        var evenNumbers = numbers.Where(NumberUtils.IsEven);

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num); // Print each even number
        }
    }
}
