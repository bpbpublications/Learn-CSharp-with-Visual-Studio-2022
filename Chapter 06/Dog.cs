public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Move()
    {
        Console.WriteLine("Run");
    }
}
