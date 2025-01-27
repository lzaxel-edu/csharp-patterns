namespace Observer.Newspapers;

public abstract class Newspaper : ISubject
{
    private readonly List<IObserver> _subscribers = new();
    public abstract string Name();
    
    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(Name());
        }
    }

    public void Attach(IObserver subscriber)
    {
        _subscribers.Add(subscriber); 
    }

    public void Detach(IObserver subscriber)
    {
        _subscribers.Remove(subscriber);
    }
}