namespace Memento;

public class Document(string value)
{
    private string _value = value;

    public void SetMemento(IMemento memento)
    {
        if (memento is DocumentMemento documentMemento) {
            _value = documentMemento.GetState();
        } else {
            throw new InvalidCastException("Invalid memento");
        }
    }

    public IMemento SaveMemento()
    {
        return new DocumentMemento(_value);
    }
    
    public string GetValue()
    {
        return _value;
    }
}