public class Container<T>
{
    public T Value { get; set; }
    public Container(T value)
    {
        Value = value;
    }
    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}
