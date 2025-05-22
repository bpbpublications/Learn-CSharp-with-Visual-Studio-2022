class ExampleProgram7
{
    // Delegate declaration
    public delegate void Notify(string message);
    static void Main7(string[] args)
    {
        // Local variable used within the lambda expression
        string prefix = "Lambda says: ";

        // Lambda expression assigned to the delegate, utilizing the local variable
        Notify notifyDelegate = (message) => Console.WriteLine(prefix + message);

        // Invoking the delegate with the lambda expression
        notifyDelegate("Hello from a lambda expression!");
    }
}
