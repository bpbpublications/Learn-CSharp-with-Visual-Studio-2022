using System;
using System.Reflection;
public class Person
{
    public string Name { get; set; } = "";
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class Program9
{
    static void Main9()
    {
        Type type = typeof(Person);
        object? instance = Activator.CreateInstance(type);

        // Set and get property
        PropertyInfo? nameProperty = type.GetProperty("Name");
        nameProperty?.SetValue(instance, "John Doe");
        Console.WriteLine($"Name: {nameProperty?.GetValue(instance)}");

        // Set and get private field
        FieldInfo? ageField = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        ageField?.SetValue(instance, 30);
        Console.WriteLine($"Age: {ageField?.GetValue(instance)}");
    }
}
