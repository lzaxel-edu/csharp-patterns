using FactoryMethod.Abstract;

namespace FactoryMethod;

public abstract class Creator
{
    protected abstract IChair CreateChair();
    protected abstract IBench CreateBench();
    protected abstract ICouch CreateCouch();
    protected abstract ISofa CreateSofa();

    public string ProcessChair()
    {
        return $"ProcessChair: {CreateChair()}";
    }
    public string ProcessSofa()
    {
        return $"Process Sofa: {CreateSofa()}";
    }
    public string ProcessBench()
    {
        return $"ProcessBench: {CreateBench()}";
    }
    public string ProcessCouch()
    {
        return $"ProcessCouch: {CreateCouch()}";
    }
}