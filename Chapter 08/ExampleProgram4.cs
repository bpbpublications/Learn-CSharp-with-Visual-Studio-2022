class ExampleProgram4
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main4(string[] args)
    {
        // Anonymous method assigned to the delegate
        Notify notifyDelegate = delegate (string message)
        {
            // Outputting the message using the anonymous method
            Console.WriteLine(message);
        };

        // Invoking the delegate with the anonymous method
        notifyDelegate("Anonymous method invoked.");
    }
}
