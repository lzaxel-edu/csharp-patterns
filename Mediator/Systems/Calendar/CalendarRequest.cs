namespace Mediator.Systems.Calendar;

public class CalendarRequest(DateOnly date) : IRequest
{
    public DateOnly Date { get; private set; } = date;
}