using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTask.Shape;

namespace MindBoxTask.Tests;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void CorrectCalcCheck()
    {
        Triangle triangle = new Triangle("Triangle", 4, 4, 5);
        double expected = 7.8;
        
        double result = triangle.CalcSquare();
        
        Assert.AreEqual(expected, result);
    }
}