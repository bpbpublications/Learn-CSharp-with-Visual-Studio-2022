class OverloadComments
{
    /// <summary>
    /// Displays a default message.
    /// </summary>
    public static void Display()
    {
        Console.WriteLine("Display method with no parameters.");
    }

    /// <summary>
    /// Displays a message that includes an integer.
    /// </summary>
    /// <param name="number">An integer to be included in the display message.</param>
    public static void Display(int number)
    {
        Console.WriteLine("Display method with one integer parameter: " + number);
    }

    /// <summary>
    /// Displays a message that includes a string.
    /// </summary>
    /// <param name="text">A string to be included in the display message.</param>
    public static void Display(string text)
    {
        Console.WriteLine("Display method with one string parameter: " + text);
    }

    /// <summary>
    /// Displays a message that includes an integer and a string.
    /// </summary>
    /// <param name="number">An integer to be included in the display message.</param>
    /// <param name="text">A string to be included in the display message.</param>
    public static void Display(int number, string text)
    {
        Console.WriteLine($"Display method with two parameters: integer = {number}, string = {text}");
    }

    static void Main()
    {
        // Calling the overloaded methods
        Display();
        Display(42);
        Display("Hello, world!");
        Display(42, "Hello, world!");
    }
}
