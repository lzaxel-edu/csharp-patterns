using System.Collections;

namespace ChainOfResponsibility.Handlers;

public interface IHandler
{
    public object HandleDocument(object document);
}