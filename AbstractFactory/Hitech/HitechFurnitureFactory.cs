using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Items;
using AbstractFactory.Hitech.Items;

namespace AbstractFactory.Hitech;

public class HitechFurnitureFactory : IFurnitureFactory
{
    public Chair CreateChair()
    {
        return new HitechChair();
    }

    public Bench CreateBench()
    {
        return new HitechBench();
    }

    public Couch CreateCouch()
    {
        return new HitechCouch();
    }

    public Sofa CreateSofa()
    {
        return new HitechSofa();
    }
}