namespace Builder;

public class BurgerBuilder : IBurgerBuilder
{
    private List<string> _ingredients;

    public BurgerBuilder()
    {
        _ingredients = new List<string>();
    }
    
    public void WithCheese()
    {
        _ingredients.Add("Cheese");
    }

    public void WithBecon()
    {
        _ingredients.Add("Becon");
    }

    public void WithTomato()
    {
        _ingredients.Add("Tomato");
    }

    public void WithBeef()
    {
        _ingredients.Add("Beef");
    }

    public Burger Build()
    {
        return new Burger(_ingredients);
    }
}