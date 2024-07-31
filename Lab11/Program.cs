using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting asynchronous operation...");

        try
        {
            // Call and await the asynchronous method
            string result = await SimulateAsyncOperation();
            Console.WriteLine($"Async operation completed with result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static async Task<string> SimulateAsyncOperation()
    {
        await Task.Delay(2000); // Simulate delay
        return "Operation successful";
    }
}
