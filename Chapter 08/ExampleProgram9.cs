class ExampleProgram9
{
    static void Main9(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        subscriber.Subscribe(publisher);
        publisher.StartProcess();
    }
}
