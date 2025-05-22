public class GenericClass<T>
{
    public T Value { get; set; }

    public GenericClass(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}
