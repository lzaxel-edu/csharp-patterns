using System.Collections;
using ChainOfResponsibility.Handlers;

namespace BehavioralTests;

public class ChainOfResponsibilityTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TextDocumentPositiveTest()
    {
        var handler = new MediaDocumentHandler(new PictureDocumentHandler(new TextDocumentHandler(null)));
        var document = new Hashtable();
        document.Add("text", "some content");

        var result = handler.HandleDocument(document);
        Assert.AreEqual("This is text document: some content", result);
    }
    
    [Test]
    public void UnknownDocumentTest()
    {
        var handler = new MediaDocumentHandler(new PictureDocumentHandler(new TextDocumentHandler(null)));
        var document = new Hashtable();

        var result = handler.HandleDocument(document);
        Assert.AreEqual(result, "Unknown document passed");
    }
    
    [Test]
    public void PictureDocumentPositiveTest()
    {
        var handler = new MediaDocumentHandler(new PictureDocumentHandler(new TextDocumentHandler(null)));
        var document = new Hashtable();
        document.Add("picture", "data");

        var result = handler.HandleDocument(document);
        Assert.AreEqual("This is picture document: data", result);
    }
    
    [Test]
    public void MediaDocumentNegativeTest()
    {
        var handler = new MediaDocumentHandler(new PictureDocumentHandler(new TextDocumentHandler(null)));
        var document = new Hashtable();
        document.Add("media_type", "video");

        var result = handler.HandleDocument(document);
        Assert.AreEqual("This is media document: video", result);
    }
}