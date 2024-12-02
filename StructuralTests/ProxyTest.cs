using Decorator;
using Decorator.Additions;
using Decorator.Coffee;
using Proxy;

namespace StructuralTests;

public class ProxyTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ProxyFileTest()
    {
        const string path = "C:\\Users\\lzaxel\\Downloads\\FileZilla_3.68.1_win64-setup.exe";
        FileProxy fp = new FileProxy(path);
        TestContext.WriteLine($"Path: {fp.GetPath()}");
        TestContext.WriteLine($"Size before: {fp.Size()}");
        TestContext.WriteLine($"ReadAll Length: {fp.ReadAll().Length}");
        TestContext.WriteLine($"Size after: {fp.Size()}");
    }
}