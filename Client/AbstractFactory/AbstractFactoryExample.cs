using AbstractFactory.Hitech;
using AbstractFactory.Loft;
using AbstractFactory.Modern;

namespace Client.AbstractFactory;

public class AbstractFactoryExample
{
    public void Run()
    {
        new AbstractFactoryUsage(new HitechFurnitureFactory()).RunExample();
        new AbstractFactoryUsage(new LoftFurnitureFactory()).RunExample();
        new AbstractFactoryUsage(new ModernFurnitureFactory()).RunExample();
    }
}