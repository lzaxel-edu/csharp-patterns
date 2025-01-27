namespace State;

public class EjectCoinState : IState
{
    public IState Spin()
    {
        throw new StateException("Insert coin first");
    }

    public IState InsertCoin()
    {
        return new InsertCoinState();
    }

    public IState EjectCoin()
    {
        throw new StateException("Coin already ejected");
    }

    public IState Dispense()
    {
        throw new StateException("Insert coin first");
    }
}