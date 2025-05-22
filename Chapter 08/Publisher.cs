public class Publisher
{
    // Event declaration using EventHandler
    public static event EventHandler ProcessCompleted;

    public void StartProcess()
    {
        // Simulate some processing work
        System.Threading.Thread.Sleep(3000);
        OnProcessCompleted(EventArgs.Empty);
    }
    protected virtual void OnProcessCompleted(ProcessEventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }

    protected virtual void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
}
