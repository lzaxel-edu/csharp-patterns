namespace State;

public interface IState
{
    IState Spin(); 
    IState InsertCoin(); 
    IState EjectCoin(); 
    IState Dispense();  
}