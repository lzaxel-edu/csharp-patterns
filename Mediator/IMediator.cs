namespace Mediator;

public interface IMediator
{
    public void Handle(IRequest request);
}