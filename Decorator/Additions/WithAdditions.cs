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
    public abstract decimal DoCost();
    public string Name() => _coffee.Name();
    public decimal Cost()
    {
        return Convert.ToDecimal(_coffee.Cost() + DoCost());
    }
}