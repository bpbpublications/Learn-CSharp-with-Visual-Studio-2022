class ExampleProgram5
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main5(string[] args)
    {
        // Assigning an anonymous method to the delegate
        Notify notifyDelegate = delegate (string message)
        {
            // Outputting the message from the anonymous method
            Console.WriteLine("Anonymous method says: " + message);
        };

        // Invoking the delegate with the anonymous method
        notifyDelegate("Hello from an anonymous method!");
    }
}
