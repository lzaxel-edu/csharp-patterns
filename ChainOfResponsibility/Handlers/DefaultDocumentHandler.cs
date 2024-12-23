using System.Collections;

namespace ChainOfResponsibility.Handlers;

public abstract class DefaultDocumentHandler(IHandler handler) : IHandler
{
    private IHandler? _handler = handler;

    public virtual object HandleDocument(object document)
    {
        if (this._handler != null)
        {
            return this._handler.HandleDocument(document);
        }
        else
        {
            return "Unknown document passed";
        }
    }
}