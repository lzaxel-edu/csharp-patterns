using FactoryMethod.Abstract;
using FactoryMethod.Hitech;

namespace FactoryMethod;

public class HitechCreator: Creator
{
    protected override IBench CreateBench()
    {
        return new HitechBench();
    }

    protected override ICouch CreateCouch()
    {
        return new HitechCouch();
    }

    protected override IChair CreateChair()
    {
        return new HitechChair();
    }

    protected override ISofa CreateSofa()
    {
        return new HitechSofa();
    }
}