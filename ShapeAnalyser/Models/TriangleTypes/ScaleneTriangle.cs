using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models.TriangleTypes
{
    public class ScaleneTriangle : IShape
    {
        public ETriangleType DetermineType() => ETriangleType.Scalene;
    }
}
