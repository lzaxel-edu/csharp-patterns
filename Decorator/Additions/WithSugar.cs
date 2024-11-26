using Decorator.Coffee;

namespace Decorator.Additions;

public class WithSugar: WithAdditions
{
    public WithSugar(ICoffee coffee) : base(coffee) {}
    public override decimal DoCost() => 3;
}