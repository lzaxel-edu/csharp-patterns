using Decorator.Coffee;

namespace Decorator.Additions;

public class WithSugar: WithAdditions
{
    public WithSugar(ICoffee coffee) : base(coffee) {}
    protected override decimal DoCost() => 3;
}