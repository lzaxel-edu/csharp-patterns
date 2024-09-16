using AbstractFactory.Abstract;

namespace Client.AbstractFactory;

public class AbstractFactoryUsage
{
    private IFurnitureFactory _currentFactory;

    public AbstractFactoryUsage(IFurnitureFactory factory)
    {
        _currentFactory = factory;
    }

    public void CreateAndPrintItems()
    {
        Console.WriteLine("Bench: {0}", _currentFactory.CreateBench());
        Console.WriteLine("Chair: {0}", _currentFactory.CreateChair());
        Console.WriteLine("Couch: {0}", _currentFactory.CreateCouch());
        Console.WriteLine("Sofa: {0}", _currentFactory.CreateSofa());
    }

    public void RunExample()
    {
        Console.WriteLine("Current factory: {0}", _currentFactory);
        CreateAndPrintItems();
        Console.WriteLine();
    }
}