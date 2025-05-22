class OverloadExample
{
    // Method with no parameters
    public static void Display()
    {
        Console.WriteLine("Display method with no parameters.");
    }

    // Overloaded method with one integer parameter
    public static void Display(int number)
    {
        Console.WriteLine("Display method with one integer parameter: " + number);
    }

    // Overloaded method with one string parameter
    public static void Display(string text)
    {
        Console.WriteLine("Display method with one string parameter: " + text);
    }

    // Overloaded method with two parameters: an integer and a string
    public static void Display(int number, string text)
    {
        Console.WriteLine($"Display method with two parameters: integer = {number}, string = {text}");
    }

    static void Main1()
    {
        // Calling the overloaded methods
        Display();
        Display(42);
        Display("Hello, world!");
        Display(42, "Hello, world!");
    }
}
