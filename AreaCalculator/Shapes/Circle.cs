using AreaCalculator.Abstractions;

namespace AreaCalculator.Shapes;

public sealed class Circle : Shape
{
    /// <exception cref="ArgumentException">Circle radius is less or equal 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Circle radius must be more than 0");
        }

        Radius = radius;
    }

    /// <summary>
    /// Circle radius.
    /// </summary>
    public double Radius { get; }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}