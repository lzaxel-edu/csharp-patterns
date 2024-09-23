using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Hitech.Items;

public class HitechBench : IBench
{
    public override string ToString()
    {
        return "I'm a hitech bench";
    }
}