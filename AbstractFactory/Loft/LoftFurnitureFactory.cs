using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Loft.Items;

namespace AbstractFactory.Loft;

public class LoftFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new LoftChair();
    }

    public IBench CreateBench()
    {
        return new LoftBench();
    }

    public ICouch CreateCouch()
    {
        return new LoftCouch();
    }

    public ISofa CreateSofa()
    {
        return new LoftSofa();
    }
}