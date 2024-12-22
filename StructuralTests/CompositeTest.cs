using Composite.BinaryTree;
using Composite.Components;

namespace StructuralTests;

public class CompositeTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CompositeSumTest()
    {
        var compositeComponent = new CompositeComponent(new List<IComponent>()
        {
            new LeafComponent(1),
            new LeafComponent(3),
            new CompositeComponent(new List<IComponent>()
                {
                    new LeafComponent(8),
                    new LeafComponent(53),
                }
            )
        });
        
        Assert.AreEqual(65, compositeComponent.GetSum());
    }

    [Test]
    public void CompositeTreeWalkTest()
    {
        var tree = new BinaryTree<IComponent>();
        tree.Insert(new LeafComponent(50));
        tree.Insert(new LeafComponent(30));
        tree.Insert(new LeafComponent(70));
        tree.Insert(new LeafComponent(20));
        tree.Insert(new LeafComponent(40));
        tree.Insert(new LeafComponent(60));
        tree.Insert(new LeafComponent(80));

        foreach (var value in tree.WalkLRR())
        {
            foreach (var item in value.GetValue())
            {
            
                TestContext.WriteLine(item);
            }    
        }
    }
}