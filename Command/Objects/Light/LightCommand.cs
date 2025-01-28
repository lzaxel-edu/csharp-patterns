namespace Command.Objects.Light;

public class LightCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.Toggle();
    }
}