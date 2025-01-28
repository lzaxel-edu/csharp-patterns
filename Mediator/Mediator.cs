using Mediator.Systems.Alarm;
using Mediator.Systems.Calendar;
using Mediator.Systems.CoffeeMachine;
using Mediator.Systems.Irrigation;

namespace Mediator;

public class Mediator : IMediator
{
    private readonly IrrigationHandler _irrigation = new();
    private readonly CoffeeMachineHandler _coffeeMachine = new();

    public void Handle(IRequest request)
    {
        switch (request)
        {
            case AlarmRequest alarmRequest:
                _irrigation.Handle(alarmRequest);
                _coffeeMachine.Handle(alarmRequest);
                break;
            case CalendarRequest calendarRequest:
                _irrigation.Handle(calendarRequest);
                break;
        }
    }
}