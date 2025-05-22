public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        Publisher.ProcessCompleted += OnProcessCompleted;
    }
    private void OnProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Process completed event received.");
    }
}
