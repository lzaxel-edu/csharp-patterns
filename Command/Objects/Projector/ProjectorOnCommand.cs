namespace Command.Objects.Screen;

public class ProjectorOnCommand(Screen screen) : ICommand
{
    public void Execute()
    {
        screen.Up();
    }
}