using System;
public class MyClass2
{
    public void MyMethod() { }
}

class Program4
{
    static void Main4()
    {
        Type type = typeof(MyClass2);
        Console.WriteLine($"Type Name: {type.Name}");
        Console.WriteLine($"Namespace: {type.Namespace}");
        Console.WriteLine($"Is Class: {type.IsClass}");
    }
}
