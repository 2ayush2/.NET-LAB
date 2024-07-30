using System;

// Delegate: A type that holds a reference to a method. It allows calling that method indirectly.
// Event: A way to notify other parts of a program when something happens.

class Program
{
    // Define a delegate that points to methods with no parameters and no return value
    public delegate void Notify();  

    // Define an event using the delegate
    public static event Notify OnNotify;

    static void Main(string[] args)
    {
        // Subscribe (add) a method to the event
        OnNotify += ShowMessage;

        // Trigger (call) the event
        TriggerEvent();
    }

    // Method that will be called when the event is triggered
    static void ShowMessage()
    {
        Console.WriteLine("Event triggered: Notification received!");
    }

    // Method to trigger the event
    static void TriggerEvent()
    {
        // Check if there are any methods subscribed to the event before triggering it
        OnNotify?.Invoke();
    }
}
