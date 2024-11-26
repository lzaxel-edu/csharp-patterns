using Bridge.TV;

namespace Bridge.Remote;

public abstract class Remote
{
    private ITV _TV { get; set; }

    public Remote(ITV tv)
    {
        if (tv == null)
        {
            throw new Exception("TV is null");
        }
        _TV = tv;
    }

    public virtual void Enable()
    {
        _TV.Toggle(true);
    }

    public virtual void Disable()
    {
        _TV.Toggle(false);
    }

    public virtual void SetChannel(uint channel)
    {
        _TV.SetChannel(channel);
    }
}