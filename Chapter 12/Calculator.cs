using System;
using System.Reflection;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program3
{
    static void Main3()
    {
        Type? type = typeof(Calculator);
        object instance = Activator.CreateInstance(type);
        MethodInfo method = type.GetMethod("Add");

        int? result = (int)method.Invoke(instance, new object[] { 5, 10 });
        Console.WriteLine($"Result: {result}");
    }
}
