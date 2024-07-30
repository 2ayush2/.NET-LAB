using System;

namespace lab
{
    internal class TextTransform
    {
        static void Main(string[] args)
        {
            // Convert to uppercase
            Console.Write("Enter a string to convert to uppercase: ");
            Console.WriteLine("Uppercase: " + Console.ReadLine()?.ToUpper());

            // Convert to lowercase
            Console.Write("Enter a string to convert to lowercase: ");
            Console.WriteLine("Lowercase: " + Console.ReadLine()?.ToLower());
        }
    }
}
