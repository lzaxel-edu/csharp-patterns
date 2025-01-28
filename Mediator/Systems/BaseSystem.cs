namespace Mediator.Systems;

public abstract class BaseSystem
{
    protected IMediator Mediator { get; private set; }

    protected BaseSystem(IMediator mediator)
    {
        ArgumentNullException.ThrowIfNull(mediator);
        Mediator = mediator;
    }

    public abstract void Request();
}