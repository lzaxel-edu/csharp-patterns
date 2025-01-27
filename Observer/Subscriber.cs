namespace Observer;

public class Subscriber(string name) : IObserver
{
    public void Update(string newspaper)
    {
        Console.WriteLine($"Subscriber {name} notified about {newspaper}");
    }
}