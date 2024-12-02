using Decorator.Coffee;

namespace Decorator.Additions;

public abstract class WithAdditions: ICoffee
{
    protected ICoffee _coffee;

    protected WithAdditions(ICoffee coffee)
    {
        if (coffee == null) throw new Exception("Coffee is null");
        _coffee = coffee;
    }
    protected abstract decimal DoCost();
    public decimal Cost()
    {
        return _coffee.Cost() + DoCost();
    }
}