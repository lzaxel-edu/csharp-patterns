using Decorator;
using Decorator.Additions;
using Decorator.Coffee;

namespace StructuralTests;

public class DecoratorTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DecoratorLatteSugarTest()
    {
        ICoffee coffee = new WithSugar(new LatteCoffee());
        decimal coffeeCost = coffee.Cost();
        
        Assert.AreEqual(23, coffeeCost);
        Assert.AreEqual("Latte with sugar", coffee.Name());
    }
    
    [Test]
    public void DecoratorLatteSugarMilkTest()
    {
        decimal coffeeCost = new WithMilk(new WithSugar(new LatteCoffee())).Cost();
        Assert.AreEqual(28, coffeeCost);
    }
    
    [Test]
    public void DecoratorMoccoSyrupDiscountTest()
    {
        decimal coffeeCost = new WithDiscount(new WithSyrup(new MoccoCoffee())).Cost();
        Assert.AreEqual(25.2, coffeeCost);
    }
}