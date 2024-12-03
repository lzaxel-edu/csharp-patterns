using Bridge.TV;

namespace Bridge.Remote;

public class ConcreteRemote: Remote
{
    public ConcreteRemote(ITV tv) : base(tv) { }
    
    public void Next()
    {
        base.SetChannel(CurrentChannel+1);
    }

    public void Previous()
    {
        base.SetChannel(CurrentChannel-1);
    }
}