namespace State;

public class VendingMachine
{
    private IState _state = new InsertCoinState();
    
    public void TurnCrank()
    {
        _state = _state.Spin();
    }
    
    public void InsertCoin()
    {
        _state = _state.InsertCoin();
    }

    public void EjectCoin()
    {
        _state = _state.EjectCoin();
    }
    
    public void Dispense()
    {
        _state = _state.Dispense();
    }
}