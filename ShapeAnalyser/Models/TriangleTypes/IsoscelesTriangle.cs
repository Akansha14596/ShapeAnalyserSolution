using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models.TriangleTypes
{
    public record IsoscelesTriangle(double Side1, double Side2, double Side3) : IShape
    {
        public ETriangleType DetermineType() => ETriangleType.Isosceles;
    }
}
