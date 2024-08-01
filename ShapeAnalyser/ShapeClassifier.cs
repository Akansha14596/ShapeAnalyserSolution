using ShapeAnalyser.Enums;
using ShapeAnalyser.Factories;
using ShapeAnalyser.Models;

namespace ShapeAnalyser
{
    public class ShapeClassifier
    {
        private readonly IShapeFactory _shapeFactory;

        public ShapeClassifier(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public string DetermineShapeType(double[] sides)
        {
            IShape shape = _shapeFactory.CreateShape(sides);
            ETriangleType shapeType = shape.DetermineType();
            return shapeType.ToString();
        }
    }
}
