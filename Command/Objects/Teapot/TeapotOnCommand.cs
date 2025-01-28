namespace Command.Objects.Teapot;

public class TeapotOnCommand(Teapot teapot) : ICommand
{
    public void Execute()
    {
        teapot.On();
    }
}