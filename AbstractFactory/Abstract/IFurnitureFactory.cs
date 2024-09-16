using AbstractFactory.Abstract.Items;

namespace AbstractFactory.Abstract;

public interface IFurnitureFactory
{
    Chair CreateChair();
    Bench CreateBench();
    Couch CreateCouch();
    Sofa CreateSofa();
}