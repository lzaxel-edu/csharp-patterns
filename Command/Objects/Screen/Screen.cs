namespace Command.Objects.Screen;

public class Screen
{
    private bool _isUp;

    public void Up() => _isUp = true;

    public void Down() => _isUp = false;
}