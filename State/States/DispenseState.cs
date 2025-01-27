namespace State;

public class DispenseState: IState
{
    public IState Spin()
    {
        throw new StateException("Already spinned");
    }

    public IState InsertCoin()
    {
        throw new StateException("Take gum first");
    }

    public IState EjectCoin()
    {
        throw new StateException("Cannot eject coin");
    }

    public IState Dispense()
    {
        return new InsertCoinState();
    }
}