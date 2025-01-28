namespace Command;

public class Remote
{
    private readonly Stack<ICommand> _history = new();
    private readonly List<(ICommand CommandOn, ICommand CommandOff)> _commands = new();

    
    public int AddCommand((ICommand CommandOn, ICommand CommandOff) command)
    {
        _commands.Append(command);
        
        return _commands.Count - 1;
    }

    public void HandleOn(int index)
    {
        if (index >= _commands.Count)
        {
            throw new IndexOutOfRangeException("Out of commands range");
        }
        
        _commands[index].CommandOn.Execute();
        _history.Push(_commands[index].CommandOff);
    }

    public void HandleOff(int index)
    {
        if (index >= _commands.Count)
        {
            throw new IndexOutOfRangeException("Out of commands range");
        }
        
        _commands[index].CommandOff.Execute();
        _history.Push(_commands[index].CommandOn);
    }

    public void HandleUndo()
    {
        if (_history.Count < 1)
        {
            return;
        }
        
        _history.Pop().Execute();
    }
}