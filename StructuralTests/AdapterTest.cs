using Adapter;

namespace StructuralTests;

public class AdapterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ServerCallerConvertTest()
    {
        List<IRequester> callers = new();

        IRequester requester = new Requester();
        IRequester serverCaller = new ServerCallerAdapter(new ServerCaller());
        
        callers.Add(requester);
        callers.Add(serverCaller);

        foreach (var caller in callers)
        {
            int status = caller.Request();
            Assert.AreEqual(status, 200);
        }
    }
}