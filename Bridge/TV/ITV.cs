namespace Bridge.TV;

public interface ITV
{
    uint CurrentChannel { get; }
    void Toggle(bool enabled);
    void SetChannel(uint channel);
}