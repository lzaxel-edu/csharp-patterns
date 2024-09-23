using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Loft.Items;

public class LoftSofa : ISofa
{
    public override string ToString()
    {
        return "I'm a loft sofa";
    }
}