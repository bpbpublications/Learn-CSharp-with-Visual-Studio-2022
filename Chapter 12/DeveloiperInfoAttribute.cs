using System;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class DeveloperInfoAttribute : Attribute
{
    public string Name { get; }
    public string Date { get; }

    public DeveloperInfoAttribute(string name, string date)
    {
        Name = name;
        Date = date;
    }
}
