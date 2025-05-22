public class NonGenericClass
{
    public void Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }
}
