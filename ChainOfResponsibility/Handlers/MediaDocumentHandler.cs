using System.Collections;

namespace ChainOfResponsibility.Handlers;

public class MediaDocumentHandler: DefaultDocumentHandler
{
    public MediaDocumentHandler(IHandler handler) : base(handler) { }

    public override object HandleDocument(object document)
    {
        if (document is IDictionary doc && doc.Contains("media_type"))
        {
            return $"This is media document: {doc["media_type"]}";
        }
        else
        {
            return base.HandleDocument(document);
        }
    }
}