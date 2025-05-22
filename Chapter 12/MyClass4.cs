using System;
using System.Reflection;
public class MyClass4
{
    public MyClass4() { }
    public MyClass4(string message)
    {
        Console.WriteLine($"Message: {message}");
    }
}

class Program6
{
    static void Main6()
    {
        Type type = typeof(MyClass4);

        // Default constructor
        object? instance1 = Activator.CreateInstance(type);
        Console.WriteLine($"Instance1 created: {instance1?.GetType().Name}");

        // Constructor with parameters
        object? instance2 = Activator.CreateInstance(type, new object[] { "Hello, Reflection!" });
        Console.WriteLine($"Instance2 created: {instance2?.GetType().Name}");
    }
}
