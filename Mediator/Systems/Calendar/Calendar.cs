namespace Mediator.Systems.Calendar;

public class Calendar(IMediator mediator) : BaseSystem(mediator)
{
    public override void Request()
    {
        Mediator.Handle(new CalendarRequest(DateOnly.FromDateTime(DateTime.UtcNow)));
    }
}