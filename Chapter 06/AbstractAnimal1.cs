public abstract class Animal1
{
    public string Name { get; set; }

    public Animal1(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public abstract void MakeSound();
}
