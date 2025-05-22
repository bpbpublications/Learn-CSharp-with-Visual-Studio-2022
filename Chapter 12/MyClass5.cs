using System;
using System.Reflection;
public class MyClass5
{
    public MyClass5(string message)
    {
        Console.WriteLine(message);
    }
}

class Program10
{
    static void Main10()
    {
        Type type = typeof(MyClass5);
        ConstructorInfo? constructor = type.GetConstructor(new Type[] { typeof(string) });

        object instance = constructor?.Invoke(new object?[] { "Hello from Reflection!" });
    }
}
