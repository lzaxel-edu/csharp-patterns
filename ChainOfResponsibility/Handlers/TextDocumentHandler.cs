using System.Collections;

namespace ChainOfResponsibility.Handlers;

public class TextDocumentHandler: DefaultDocumentHandler
{
    public TextDocumentHandler(IHandler handler) : base(handler) { }

    public override object HandleDocument(object document)
    {
        if (document is IDictionary doc && doc.Contains("text"))
        {
            return $"This is text document: {doc["text"]}";
        }
        else
        {
            return base.HandleDocument(document);
        }
    }
}