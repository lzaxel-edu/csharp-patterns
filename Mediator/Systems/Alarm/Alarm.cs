namespace Mediator.Systems.Alarm;

public class Alarm(IMediator mediator) : BaseSystem(mediator)
{
    public override void Request()
    {
        Mediator.Handle(new AlarmRequest(TimeOnly.FromDateTime(DateTime.UtcNow)));
    }
}