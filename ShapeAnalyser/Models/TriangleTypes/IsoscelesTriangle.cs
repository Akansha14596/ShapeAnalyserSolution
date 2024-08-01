using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models.TriangleTypes
{
    public class IsoscelesTriangle : IShape
    {
        public ETriangleType DetermineType() => ETriangleType.Isosceles;
    }
}
