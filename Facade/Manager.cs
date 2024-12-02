using Facade.Roles;

namespace Facade;

public class Manager
{
    protected Backender _backender;
    protected Frontender _frontender;
    protected Designer _designer;

    public Manager(Backender backend, Frontender frontend, Designer design)
    {
        _designer = design ?? throw new ArgumentNullException();
        _backender = backend ?? throw new ArgumentNullException();
        _frontender = frontend ?? throw new ArgumentNullException();
    }

    public void AddButton()
    {
        _designer.Draw();
        _frontender.Develop();
        _backender.Develop();
    }

    public void FixUI()
    {
        _designer.Redraw(); 
        _frontender.Fix();
    }

    public void FixCalc()
    {
        _backender.Fix();
    }
}