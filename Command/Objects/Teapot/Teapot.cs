namespace Command.Objects.Teapot;

public class Teapot
{
    private bool _isTurnedOn;

    public void On() => _isTurnedOn = true;
    public void Off() => _isTurnedOn = false;
}