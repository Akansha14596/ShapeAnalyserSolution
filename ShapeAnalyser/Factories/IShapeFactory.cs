using ShapeAnalyser.Models;

namespace ShapeAnalyser.Factories
{
    public interface IShapeFactory
    {
        IShape CreateShape(double[] sides);
    }
}
