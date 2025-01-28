namespace Command.Objects.Projector;

public class Projector
{
    private bool _isTurnedOn;
    public void On() => _isTurnedOn = true;
    
    public void Off() => _isTurnedOn = false;
}