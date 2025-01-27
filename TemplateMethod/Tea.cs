namespace TemplateMethod;

public class Tea: Buffet
{
    protected override void Ingredient()
    {
        Console.WriteLine("Tea");
    }

    protected override void Adds()
    {
        Console.WriteLine("Lemon");
    }
   
}