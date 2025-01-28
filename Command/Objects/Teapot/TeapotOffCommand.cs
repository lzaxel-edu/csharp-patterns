namespace Command.Objects.Teapot;

public class TeapotOffCommand(Teapot teapot) : ICommand
{
    public void Execute()
    {
        teapot.Off();
    }
}