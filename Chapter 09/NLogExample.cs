using NLog;
class NLogExample
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    static void Main1(string[] args)
    {
        Logger.Info("Application started.");
        try
        {
            int x = 5;
            int y = 0;
            int result = x / y; // This will throw an exception
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "An error occurred while dividing by zero.");
        }
        Logger.Info("Application ended.");
    }
}
