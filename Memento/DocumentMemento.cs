namespace Memento;

public class DocumentMemento(string state) : IMemento
{
    private readonly DateTime _date = DateTime.UtcNow;

    public string GetState()
    {
        return state;
    }
    
    public DateTime GetDate()
    {
        return _date;
    }
}