using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models
{
    public interface IShape
    {
        ETriangleType DetermineType();
    }
}
