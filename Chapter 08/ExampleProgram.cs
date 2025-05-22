class ExampleProgram
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main1(string[] args)
    {
        // Assign the delegate to the method
        Notify notifyDelegate = ShowMessage;

        // Invoke the delegate
        notifyDelegate("Hello, Single-cast Delegate!");
    }

    // Method that matches the delegate signature
    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
