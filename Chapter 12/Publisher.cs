using System;
using System.Reflection;
public class Publisher
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

class Program11
{
    static void Main11()
    {
        Type type = typeof(Publisher);
        object instance = Activator.CreateInstance(type);
        EventInfo eventInfo = type.GetEvent("MyEvent");

        EventHandler handler = new EventHandler((sender, e) =>
        {
            Console.WriteLine("Event raised!");
        });

        eventInfo.AddEventHandler(instance, handler);

        MethodInfo raiseEventMethod = type.GetMethod("RaiseEvent");
        raiseEventMethod.Invoke(instance, null);
    }
}
