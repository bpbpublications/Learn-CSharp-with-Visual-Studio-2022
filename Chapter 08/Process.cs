// Delegate declaration
public delegate void ProcessCompletedEventHandler(string message);

// Event publisher class
class Process
{
    // Event declaration using the delegate
    public event ProcessCompletedEventHandler ProcessCompleted;

    public void StartProcess()
    {
        // Simulate some processing work with a delay
        System.Threading.Thread.Sleep(3000);

        // Raise the event after the process is completed
        OnProcessCompleted("Process completed successfully!");
    }

    // Protected method to raise the event
    protected virtual void OnProcessCompleted(string message)
    {
        // Invoke the event if there are any subscribers
        ProcessCompleted?.Invoke(message);
    }
}

