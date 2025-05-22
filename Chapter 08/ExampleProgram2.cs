class ExampleProgram2
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main2(string[] args)
    {
        // Assign the delegate to the first method
        Notify notifyDelegate = ShowMessage;

        // Add another method to the delegate's invocation list
        notifyDelegate += ShowAnotherMessage;

        // Invoke the multi-cast delegate
        notifyDelegate("Hello, Multi-cast Delegates!");
    }
    // First method that matches the delegate signature
    static void ShowMessage(string message)
    {
        Console.WriteLine("First method: " + message);
    }
    // Second method that matches the delegate signature
    static void ShowAnotherMessage(string message)
    {
        Console.WriteLine("Second method: " + message);
    }
}
