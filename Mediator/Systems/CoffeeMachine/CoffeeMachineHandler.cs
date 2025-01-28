using Mediator.Systems.Alarm;

namespace Mediator.Systems.CoffeeMachine;

public class CoffeeMachineHandler
{
    public void Handle(AlarmRequest request)
    {
        if (request.Time.Hour == 8)
        {
            Console.WriteLine("Making coffee");
        }
    }
}