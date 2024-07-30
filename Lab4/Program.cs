using System;

namespace Encapsulation
{
    internal class Program
    {
        class Container
        {
            private string[] items = new string[3];

            // Indexer to access items by index
            public string this[int index]
            {
                get => items[index];
                set => items[index] = value;
            }

            // Property to get the count of items
            public int ItemCount => items.Length;
        }

        static void Main(string[] args)
        {
            var container = new Container
            {
                [0] = "Apple",
                [1] = "Banana",
                [2] = "Cherry"
            };

            // Display items
            Console.WriteLine("Items:");
            for (int i = 0; i < container.ItemCount; i++)
                Console.WriteLine(container[i]);
        }
    }
}
