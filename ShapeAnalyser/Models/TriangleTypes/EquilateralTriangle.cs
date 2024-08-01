using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models.TriangleTypes
{
    public record EquilateralTriangle(double Side1, double Side2, double Side3) : IShape
    {
        public ETriangleType DetermineType() => ETriangleType.Equilateral;   
    }
}
