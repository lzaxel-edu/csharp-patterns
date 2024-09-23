using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Hitech.Items;

namespace AbstractFactory.Hitech;

public class HitechFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new HitechChair();
    }

    public IBench CreateBench()
    {
        return new HitechBench();
    }

    public ICouch CreateCouch()
    {
        return new HitechCouch();
    }

    public ISofa CreateSofa()
    {
        return new HitechSofa();
    }
}