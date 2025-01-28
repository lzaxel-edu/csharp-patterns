namespace Mediator.Systems.Alarm;

public class AlarmRequest(TimeOnly time) : IRequest
{
    public TimeOnly Time { get; } = time;
}