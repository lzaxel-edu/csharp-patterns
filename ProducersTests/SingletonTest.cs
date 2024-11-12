using Prototype;
using Prototype.Info;
using Singleton;

namespace ProducersTests;

public class SingletonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ComparingSingletonInstancesTest()
    {
        Assert.AreSame(SingletonConfig.Instance, SingletonConfig.Instance);
        
        Assert.Pass();
    }
}