using System;
using System.Reflection;
[Obsolete("This class is obsolete")]
public class MyClass
{
    public void MyMethod() { }
}

class Program2
{
    static void Main2()
    {
        Type type = typeof(MyClass);
        object[] attributes = type.GetCustomAttributes(false);

        foreach (var attribute in attributes)
        {
            Console.WriteLine(attribute);
        }
    }
}
