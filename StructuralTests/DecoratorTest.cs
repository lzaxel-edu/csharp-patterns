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
        decimal coffeeCost = new WithSugar(new LatteCoffee()).Cost();
        Assert.AreEqual(23, coffeeCost);
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