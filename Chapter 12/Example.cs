using System;
using System.Reflection;
public class Example
{
    public void Method1() { }
    public void Method2() { }
}
class Program1
{
    static void Main1()
    {
        // Retrieve type information of the 'Example' class.
        Type type = typeof(Example);

        // Get all methods from the 'Example' class using reflection.
        MethodInfo[] methods = type.GetMethods();

        // Loop through the methods and print their names.
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
