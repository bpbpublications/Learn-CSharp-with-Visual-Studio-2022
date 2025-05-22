// Event subscriber class
class ExampleProgram8
{
    static void Main(string[] args)
    {
        // Create an instance of the Process class
        Process process = new Process();

        // Subscribe to the ProcessCompleted event
        process.ProcessCompleted += Process_ProcessCompleted;

        // Start the process
        process.StartProcess();
    }

    // Event handler method that matches the delegate signature
    static void Process_ProcessCompleted(string message)
    {
        // Output the event message to the console
        Console.WriteLine(message);
    }
}
