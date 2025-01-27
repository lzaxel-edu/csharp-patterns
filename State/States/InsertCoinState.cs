namespace State;

public class InsertCoinState : IState
{
    public IState Spin()
    {
        return new SpinState();
    }

    public IState InsertCoin()
    {
        throw new StateException("Coin already inserted");
    }

    public IState EjectCoin()
    {
        return new EjectCoinState();
    }

    public IState Dispense()
    {
        throw new StateException("Insert coin first");
    }
}