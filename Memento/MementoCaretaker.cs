namespace Memento;

public class MementoCaretaker
{
    private readonly List<IMemento> _mementoList = new();
        
    public void SaveState(IMemento memento)
    {
        _mementoList.Add(memento);
    }

    private IMemento GetLastState()
    {
        if (_mementoList.Count != 0) {
            return _mementoList[^1];
        } 
        
        throw new Exception("Memento list is empty");
    }
}