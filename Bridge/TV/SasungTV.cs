namespace Bridge.TV;

public class SasungTV: ITV
{
    public uint CurrentChannel { get; private set; } = 1;
    public bool IsEnabled { get; private set; } = false;
    
    public void Toggle(bool enabled)
    {
        IsEnabled = enabled;
    }

    public void SetChannel(uint channel)
    {
        CurrentChannel = channel;
    }
}