using FactoryMethod.Abstract;

namespace FactoryMethod.Loft;

public class LoftCouch : ICouch
{
    public override string ToString()
    {
        return "I'm a loft couch";
    }
}