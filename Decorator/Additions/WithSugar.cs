using Decorator.Coffee;

namespace Decorator.Additions;

public class WithSugar: WithAdditions
{
    public WithSugar(ICoffee coffee) : base(coffee) {}
    protected override decimal DoCost() => 3;
    protected override string DoName() => " with sugar";
}