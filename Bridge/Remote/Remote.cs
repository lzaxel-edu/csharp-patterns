using Bridge.TV;

namespace Bridge.Remote;

public abstract class Remote
{
    protected ITV _tv;

    public Remote(ITV tv)
    {
        _tv = tv;
    }

    public virtual void Enable()
    {
        _tv.Toggle(true);
    }

    public virtual void Disable()
    {
        _tv.Toggle(false);
    }

    public virtual void SetChannel(uint channel)
    {
        _tv.SetChannel(channel);
    }
}