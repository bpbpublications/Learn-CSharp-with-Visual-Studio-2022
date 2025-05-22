using System;
using System.Reflection;
public class MyClass3
{
    public int MyProperty { get; set; }
    public event EventHandler MyEvent;
    public void MyMethod() { }
}

class Program5
{
    static void Main5()
    {
        Type type = typeof(MyClass3);

        Console.WriteLine("Methods:");
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nProperties:");
        foreach (var property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nEvents:");
        foreach (var ev in type.GetEvents())
        {
            Console.WriteLine(ev.Name);
        }
    }
}
