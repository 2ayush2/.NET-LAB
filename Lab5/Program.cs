using System;

namespace OverloadingAndOverriding
{
    // Base class with method to be overridden
    class Animal
    {
        public Animal() => Console.WriteLine("Animal created");

        public Animal(string name) => Console.WriteLine($"Animal named {name} created");

        public virtual void Speak() => Console.WriteLine("Animal makes a sound");
    }

    // Derived class with overridden method and constructor overloading
    class Dog : Animal
    {
        public Dog() : base() => Console.WriteLine("Dog created");

        public Dog(string name) : base(name) => Console.WriteLine($"Dog named {name} created");

        public override void Speak() => Console.WriteLine("Dog barks");
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Constructor overloading
            Animal a1 = new Dog();
            Animal a2 = new Dog("Buddy");

            // Method overriding
            a1.Speak(); // Output: Dog barks
            a2.Speak(); // Output: Dog barks
        }
    }
}
