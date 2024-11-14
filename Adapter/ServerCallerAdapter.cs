namespace Adapter;

public class ServerCallerAdapter: IRequester
{
    private readonly IServerCaller _serverCaller;

    public ServerCallerAdapter(IServerCaller serverCaller)
    {
        _serverCaller = serverCaller;
    }

    public int Request()
    {
        return _serverCaller.DoServerCall();
    }
}