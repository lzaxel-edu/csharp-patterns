namespace State;

public class SpinState: IState
{
    public IState Spin()
    {
        return new DispenseState();
    }

    public IState InsertCoin()
    {
        throw new StateException("Coin already inserted");
    }

    public IState EjectCoin()
    {
        throw new StateException("Cannot eject coin");
    }

    public IState Dispense()
    {
        throw new StateException("Should spin first");
    }
}