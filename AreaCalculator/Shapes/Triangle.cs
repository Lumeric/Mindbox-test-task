using AreaCalculator.Abstractions;

namespace AreaCalculator.Shapes;

public class Triangle : Shape
{
    /// <exception cref="ArgumentException">One or more parameters are invalid.</exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("Triangle side must be more than 0.");
        }

        if (firstSide + secondSide <= thirdSide
            || firstSide + thirdSide <= secondSide
            || secondSide + thirdSide <= firstSide)
        {
            throw new ArgumentException("Triangle does not exist.");
        }

        Sides = new[] { firstSide, secondSide, thirdSide };
    }

    /// <summary>
    /// Array of triangle side lengths.
    /// </summary>
    public double[] Sides { get; }

    /// <summary>
    /// Get an indication that the triangle is right.
    /// </summary>
    /// <param name="tolerance">Calculation accuracy.</param>
    public bool IsRight(double tolerance = 1E-10)
    {
        Array.Sort(Sides);

        return Math.Abs(Math.Pow(Sides[2], 2) - (Math.Pow(Sides[1], 2) + Math.Pow(Sides[0], 2))) < tolerance;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = (Sides[0] + Sides[1] + Sides[2]) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - Sides[0]) * (semiPerimeter - Sides[1]) * (semiPerimeter - Sides[2]));
    }
}