using System;

// Interface: A blueprint for classes with methods that must be implemented.
// Multiple Inheritance: Using interfaces in C# to allow a class to inherit behaviors from more than one source.

// Define the first interface
interface IAnimal
{
    void Eat(); // Method for eating
}

// Define the second interface
interface IPet
{
    void Play(); // Method for playing
}

// Class that uses both IAnimal and IPet interfaces
class Dog : IAnimal, IPet
{
    // Implementing the Eat method
    public void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }

    // Implementing the Play method
    public void Play()
    {
        Console.WriteLine("Dog is playing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();

        // Calling methods from both interfaces
        myDog.Eat();  // Output: Dog is eating.
        myDog.Play(); // Output: Dog is playing.
    }
}
