using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Abstract;

public interface IFurnitureFactory
{
    IChair CreateChair();
    IBench CreateBench();
    ICouch CreateCouch();
    ISofa CreateSofa();
}