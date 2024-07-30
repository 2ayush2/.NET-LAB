using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                Console.WriteLine("String is too short to swap characters.");
                return;
            }

            // Swap first and last characters
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string middlePart = input.Substring(1, input.Length - 2);

            string result = lastChar + middlePart + firstChar;
            Console.WriteLine("Resulting string: " + result);
        }
    }
}
