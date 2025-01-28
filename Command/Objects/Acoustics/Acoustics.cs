namespace Command.Objects.Acoustics;

public class Acoustics
{
    private bool _isTurnedOn;
    
    public void On() => _isTurnedOn = true;
    
    public void Off() => _isTurnedOn = false;
}