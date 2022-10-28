using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTask.Shape;

namespace MindBoxTask.Tests;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void CorrectCalkCheck()
    {
        Circle circle = new Circle("Circle",12);
        double expected = 452.4;
        
        double result = circle.CalcSquare();
        
        Assert.AreEqual(expected, result);
    }
}
    
