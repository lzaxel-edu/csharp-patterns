using Bridge.TV;

namespace Bridge.Remote;

public abstract class Remote
{
    private ITV _tv;
    public uint CurrentChannel
    {
        get => _tv.CurrentChannel;
    }

    public Remote(ITV tv)
    {
        if (tv == null)
        {
            throw new ArgumentException("TV is null");
        }
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