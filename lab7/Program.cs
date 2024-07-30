using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int result = 10 / number;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input.");
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}
