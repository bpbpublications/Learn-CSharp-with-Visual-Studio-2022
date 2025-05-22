public class MediaDevice : IPlayable, IRecordable
{
    public void Play()
    {
        Console.WriteLine("Playing media");
    }

    public void Record()
    {
        Console.WriteLine("Recording media");
    }
}
