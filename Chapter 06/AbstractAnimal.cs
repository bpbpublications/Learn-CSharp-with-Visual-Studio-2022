public abstract class AbstractAnimal : IAnimal
{
    public abstract void MakeSound();
    public void Move()
    {
        Console.WriteLine("Abstract animal moving");
    }
}
