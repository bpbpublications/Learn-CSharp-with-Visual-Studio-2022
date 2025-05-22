public class ProcessEventArgs : EventArgs
{
    public string Message { get; }

    public ProcessEventArgs(string message)
    {
        Message = message;
    }
}
