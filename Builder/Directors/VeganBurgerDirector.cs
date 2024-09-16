namespace Builder;

public class VeganBurgerDirector
{
    private readonly IBurgerBuilder _builder;

    public VeganBurgerDirector(IBurgerBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.WithCheese();
        _builder.WithTomato();
    }
}