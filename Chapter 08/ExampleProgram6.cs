class ExampleProgram6
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main6(string[] args)
    {
        // Lambda expression assigned to the delegate
        Notify notifyDelegate = (message) => Console.WriteLine(message);

        // Invoking the delegate with the lambda expression
        notifyDelegate("Lambda expression invoked.");
    }
}
