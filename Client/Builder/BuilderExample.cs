using Builder;

namespace Client.Builder;

public class BuilderExample
{
    public void Run()
    {
        ExampleDefault();
        ExampleString();
        ExampleTest();
    }

    private void ExampleDefault()
    {
        Console.WriteLine("BurgerBuilder, FullBurgerDirector");
        var builder = new BurgerBuilder();
        var director = new FullBurgerDirector(builder);
        director.Build();
        
        var burger = builder.Build();
        Console.WriteLine(burger);
        Console.WriteLine();
    }
    
    private void ExampleString()
    {
        Console.WriteLine("StringBurgerBuilder, FullBurgerDirector");
        var builder = new StringBurgerBuilder();
        var director = new FullBurgerDirector(builder);
        director.Build();
        
        var burger = builder.Build();
        Console.WriteLine(burger);
        Console.WriteLine();
    }
    
    private void ExampleTest()
    {
        Console.WriteLine("TestBurgerBuilder, FullBurgerDirector");
        var builder = new TestBurgerBuilder();
        var director = new FullBurgerDirector(builder);
        director.Build();
        
        var burger = builder.Build();
        Console.WriteLine(burger);
        Console.WriteLine();
    }
}