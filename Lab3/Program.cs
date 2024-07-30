using System;

namespace lab
{
    internal class Program
    {
        // Define the Person class with properties and a method
        class Person
        {
            public string? Name { get; set; } // Property to store the name
            public int Age { get; set; }      // Property to store the age

            // Method to display person information
            public void DisplayInfo() =>
                Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        static void Main(string[] args)
        {
            // Create and initialize the first person
            var person1 = new Person { Name = "Alice", Age = 25 };
            
            // Create and initialize the second person
            var person2 = new Person { Name = "Bob", Age = 30 };

            // Display information for the first person
            Console.WriteLine("Person 1:");
            person1.DisplayInfo();
            
            // Display information for the second person
            Console.WriteLine("\nPerson 2:");
            person2.DisplayInfo();
        }
    }
}
