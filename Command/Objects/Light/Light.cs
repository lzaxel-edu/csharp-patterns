namespace Command.Objects.Light;

public class Light
{
    private bool _isTurnedOn;

    public void Toggle() => _isTurnedOn = !_isTurnedOn;
}