using Bridge.TV;

namespace Bridge.Remote;

public class ConcreteRemote: Remote
{
    public uint CurrentChannel { get; private set; } = 1;
    
    public ConcreteRemote(ITV tv) : base(tv) { }
    
    public void Next()
    {
        CurrentChannel++;
        base.SetChannel(CurrentChannel);
    }

    public void Previous()
    {
        CurrentChannel--;
        base.SetChannel(CurrentChannel);
    }
}