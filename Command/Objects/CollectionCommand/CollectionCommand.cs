namespace Command.Objects.CollectionCommand;

public class CollectionCommand(List<(ICommand OnCommand, ICommand OffCommand)> commands, bool isOn)
    : ICommand
{
    public void Execute()
    {
        foreach (var command in commands)
        {
            if (isOn)
            {
                command.OnCommand.Execute();
            }
            else
            {
                command.OffCommand.Execute();
            }
        }
    }
}