namespace Command.Objects.Screen;

public class ScreenDownCommand(Screen screen) : ICommand
{
    public void Execute()
    {
        screen.Down();
    }
}