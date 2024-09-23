using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Hitech.Items;

public class HitechSofa : ISofa
{
    public override string ToString()
    {
        return "I'm a hitech sofa";
    }
}