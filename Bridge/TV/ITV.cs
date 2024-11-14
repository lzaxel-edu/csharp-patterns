namespace Bridge.TV;

public interface ITV
{
    void Toggle(bool enabled);
    void SetChannel(uint channel);
}