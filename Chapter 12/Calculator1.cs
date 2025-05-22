using System;
using System.Reflection;
public class Calculator1
{
    public int Multiply(int x, int y)
    {
        return x * y;
    }
}

class Program7
{
    static void Main7()
    {
        Type type = typeof(Calculator1);
        object? instance = Activator.CreateInstance(type);
        MethodInfo? method = type.GetMethod("Multiply");

        int? result = (int?)method?.Invoke(instance, new object[] { 6, 7 });
        Console.WriteLine($"Result: {result}");
    }
}
