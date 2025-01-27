namespace TemplateMethod;

public abstract class Buffet
{
    public void Cook(bool withSugar = false)
    {
        BoilWater();
        Ingredient();
        IsSugar(withSugar);
        AddSugar();
        Adds();
    }
    
    protected abstract void Ingredient();
    
    protected abstract void Adds();
    
    private static void BoilWater()
    
    {
        Console.WriteLine("Boil water");
    }

    private static void IsSugar(bool withSugar)
    {
        Console.WriteLine(withSugar ? "Adding Sugar" : "No sugar(");
    }

    private static void AddSugar()
    {
        Console.WriteLine("Sugar added");
    }
}