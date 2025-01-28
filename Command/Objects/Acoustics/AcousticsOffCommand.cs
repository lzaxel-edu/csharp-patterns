namespace Command.Objects.Acoustics;

public class AcousticsOffCommand(Acoustics acoustics) : ICommand
{
    public void Execute()
    {
        acoustics.Off();
    }
}