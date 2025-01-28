using Mediator.Systems.Alarm;
using Mediator.Systems.Calendar;

namespace Mediator.Systems.Irrigation;

public class IrrigationHandler
{
    public void Handle(CalendarRequest request)
    {
        if (request.Date.DayOfWeek is not (DayOfWeek.Saturday or DayOfWeek.Sunday))
        {
            Console.WriteLine("Feeding plants with water");
        }
    }
    public void Handle(AlarmRequest request)
    {
        if (request.Time.Hour % 6 == 0)
        {
            Console.WriteLine("Feeding plants with water");
        }
    }
}