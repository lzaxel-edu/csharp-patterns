using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Loft.Items;

public class LoftBench : IBench
{
    public override string ToString()
    {
        return "I'm a loft bench";
    }
}