using System.Collections;
using ChainOfResponsibility.Handlers;
using Strategy;
using Strategy.Strategies;

namespace BehavioralTests;

public class StrategyTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BubbleSortStrategyTest()
    {
        var list = new List<double>() { 2.3,6.2,0.2,2.4};

        var context = new Context(new BubbleSortStrategy());
        var result = context.SoSmartOperation(list);

        Assert.AreEqual(new List<double>() {0.2,2.3,2.4,6.2}, result.ToList());
    }
    
    [Test]
    public void SelectionSortStrategyTest()
    {
        var list = new List<double>() { 2.3,6.2,0.2,2.4};

        var context = new Context(new SelectionSortStrategy());
        var result = context.SoSmartOperation(list);

        Assert.AreEqual(new List<double>() {0.2,2.3,2.4,6.2}, result.ToList());
    }
    
    [Test]
    public void SpeedSortsStrategyTest()
    {
        var random = new Random();
        var list1 = new List<double>();
        var list2 = new List<double>();
        for (var i = 0; i < 10000; i++)
        {
            var num = random.NextDouble();
            list1.Add(num);
            list2.Add(num);
        }

        var watch = System.Diagnostics.Stopwatch.StartNew();
        new BubbleSortStrategy().Sort(list1);
        watch.Stop();
        TestContext.WriteLine($"Bubble sort: {watch.ElapsedMilliseconds} ms");
        
        watch = System.Diagnostics.Stopwatch.StartNew();
        new SelectionSortStrategy().Sort(list1);
        watch.Stop();
        TestContext.WriteLine($"Selection sort: {watch.ElapsedMilliseconds} ms");
    }
}