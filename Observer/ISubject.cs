namespace Observer;

public interface ISubject
{
    void Notify();
    void Attach(IObserver subscriber);
    void Detach(IObserver subscriber);
}