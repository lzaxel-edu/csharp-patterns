namespace Command.Objects.Acoustics;

public class AcousticsOnCommand(Acoustics acoustics) : ICommand
{
    public void Execute()
    {
        acoustics.On();
    }
}