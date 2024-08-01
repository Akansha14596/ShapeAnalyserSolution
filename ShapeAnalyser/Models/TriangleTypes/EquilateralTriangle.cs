using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models.TriangleTypes
{
    public class EquilateralTriangle : IShape
    {
        public ETriangleType DetermineType() => ETriangleType.Equilateral;   
    }
}
