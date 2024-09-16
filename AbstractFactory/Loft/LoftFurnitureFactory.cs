using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Loft.Items;

namespace AbstractFactory.Loft;

public class LoftFurnitureFactory : IFurnitureFactory
{
    public Chair CreateChair()
    {
        return new LoftChair();
    }

    public Bench CreateBench()
    {
        return new LoftBench();
    }

    public Couch CreateCouch()
    {
        return new LoftCouch();
    }

    public Sofa CreateSofa()
    {
        return new LoftSofa();
    }
}