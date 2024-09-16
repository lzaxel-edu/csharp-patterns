using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Modern.Items;

namespace AbstractFactory.Modern;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public Bench CreateBench()
    {
        return new ModernBench();
    }

    public Couch CreateCouch()
    {
        return new ModernCouch();
    }

    public Sofa CreateSofa()
    {
        return new ModernSofa();
    }
}