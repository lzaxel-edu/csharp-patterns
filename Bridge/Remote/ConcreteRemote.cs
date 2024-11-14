using Bridge.TV;

namespace Bridge.Remote;

public class ConcreteRemote: Remote
{
    public uint CurrentChannel { get; private set; } = 1;
    
    public ConcreteRemote(ITV tv) : base(tv) { }

    public override void Enable()
    {
        _tv.Toggle(true);
    }

    public override void Disable()
    {
        _tv.Toggle(false);
    }

    public override void SetChannel(uint channel) 
    {
        if (CurrentChannel < channel)
        {
            while (CurrentChannel != channel)
            {
                Next();
            }
        }
        else
        {
            while (CurrentChannel != channel)
            {
                Previous();
            }
        }
    } 

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