using System.Collections;

namespace ChainOfResponsibility.Handlers;

public class PictureDocumentHandler: DefaultDocumentHandler
{
    public PictureDocumentHandler(IHandler handler) : base(handler) {}

    public override object HandleDocument(object document)
    {
        if (document is IDictionary doc && doc.Contains("picture"))
        {
            return $"This is picture document: {doc["picture"]}";
        }
        else
        {
            return base.HandleDocument(document);
        }
    }
}