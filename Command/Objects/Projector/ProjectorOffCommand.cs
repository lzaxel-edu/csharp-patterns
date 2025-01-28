namespace Command.Objects.Projector;

public class ProjectorOnCommand(Projector projector) : ICommand
{
    public void Execute()
    {
        projector.On();
    }
}