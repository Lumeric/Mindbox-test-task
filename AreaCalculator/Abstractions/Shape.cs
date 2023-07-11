namespace AreaCalculator.Abstractions;

/// <summary>
/// Base shape class.
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Calculate shape area.
    /// <remarks>Units of input: if input is in centimeters, so the result is squared centimeters. Same for other units.</remarks>
    /// </summary>
    public abstract double CalculateArea();

    public override string ToString() => @$"Shape type is ""{GetType().Name}"". Area is ""{CalculateArea():N}""";
}