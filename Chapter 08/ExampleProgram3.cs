
class ExampleProgram3
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main3(string[] args)
    {
        // Creating a delegate instance and assigning it to the ShowMessage method
        Notify notifyDelegate = ShowMessage;

        // Adding another method to the delegate's invocation list
        notifyDelegate += ShowAnotherMessage;

        // Invoking the multi-cast delegate before removing any method
        notifyDelegate("Before removal.");

        // Removing the ShowAnotherMessage method from the delegate's invocation list
        notifyDelegate -= ShowAnotherMessage;

        // Invoking the delegate after the removal to demonstrate the effect
        notifyDelegate("After removal.");
    }

    // First method that matches the delegate signature
    static void ShowMessage(string message)
    {
        // Outputting the message from the first method
        Console.WriteLine("First method: " + message);
    }

    // Second method that matches the delegate signature
    static void ShowAnotherMessage(string message)
    {
        // Outputting the message from the second method
        Console.WriteLine("Second method: " + message);
    }
}
