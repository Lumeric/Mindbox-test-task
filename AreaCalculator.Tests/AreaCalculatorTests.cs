using AreaCalculator.Shapes;
using NUnit.Framework;

namespace AreaCalculator.Tests;

[TestFixture]
public class AreaCalculatorTests
{
    [Test]
    public void CreateCircle_NegativeRadiusInput_ExceptionThrown()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Circle(-7);
        });
    }

    [Test]
    public void CalculateCircleArea_ValidRadiusInput_ReturnArea()
    {
        var circle = new Circle(7);

        var area = circle.CalculateArea();

        Assert.AreEqual(153.93804002589985, area);
    }

    [Test]
    public void CreateTriangle_NegativeSideInput_ExceptionThrown()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: -7, secondSide: 0, thirdSide: 0);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 0, secondSide: -7, thirdSide: 0);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 0, secondSide: 0, thirdSide: -7);
        });
    }

    [Test]
    public void CreateTriangle_SumOfTwoSideIsLessOrEqualThanThird_ExceptionThrown()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 1, secondSide: 2, thirdSide: 3);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 1, secondSide: 2, thirdSide: 4);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 2, secondSide: 3, thirdSide: 1);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 1, secondSide: 4, thirdSide: 2);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 3, secondSide: 2, thirdSide: 1);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _ = new Triangle(firstSide: 4, secondSide: 2, thirdSide: 1);
        });
    }

    [Test]
    public void CalculateTriangleArea_ValidSidesInput_ReturnArea()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 6, thirdSide: 7);

        var area = triangle.CalculateArea();

        Assert.AreEqual(8.9442719099991592, area);
    }

    [Test]
    public void IsRightTriangle_RightTriangleSidesInput_ReturnTrue()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 4, thirdSide: 5);

        var isRight = triangle.IsRight();

        Assert.IsTrue(isRight);
    }

    [Test]
    public void IsRightTriangle_NotRightTriangleSidesInput_ReturnFalse()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 6, thirdSide: 7);

        var isRight = triangle.IsRight();

        Assert.IsFalse(isRight);
    }


    [Test]
    public void IsRightTriangle_NotRightTriangleSidesInputTooBigTolerance_ReturnTrue()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 6, thirdSide: 7);

        var isRight = triangle.IsRight(100);

        Assert.IsTrue(isRight);
    }
}