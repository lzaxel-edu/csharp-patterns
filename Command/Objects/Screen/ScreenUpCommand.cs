namespace Command.Objects.Screen;

public class ScreenUpCommand(Screen screen) : ICommand
{
    public void Execute()
    {
        screen.Up();
    }
}