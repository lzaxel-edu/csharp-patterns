using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Modern.Items;

namespace AbstractFactory.Modern;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public IBench CreateBench()
    {
        return new ModernBench();
    }

    public ICouch CreateCouch()
    {
        return new ModernCouch();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}