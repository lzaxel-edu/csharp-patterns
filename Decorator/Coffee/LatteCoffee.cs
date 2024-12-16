namespace Decorator.Coffee;

public class LatteCoffee: ICoffee
{
    public decimal Cost() => 20;
    public string Name() => "Latte";
}