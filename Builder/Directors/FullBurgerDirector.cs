namespace Builder;

public class FullBurgerDirector
{
    private IBurgerBuilder _builder;
    
    public FullBurgerDirector(IBurgerBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.WithCheese();
        _builder.WithBecon();
        _builder.WithBeef();
        _builder.WithTomato();
    }
}