using ShapeAnalyser.Models;
using ShapeAnalyser.Models.TriangleTypes;

namespace ShapeAnalyser.Factories
{
    public class TriangleFactory : IShapeFactory
    {
        public IShape CreateShape(double[] sides)
        {
            if (sides.Length != 3)
            {
                throw new ArgumentException("A triangle must have exactly three sides.");
            }

            double side1 = sides[0];
            double side2 = sides[1];
            double side3 = sides[2];

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Sides must be greater than zero.");
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("The given sides do not form a triangle.");
            }

            if (side1 == side2 && side2 == side3)
            {
                return new EquilateralTriangle();
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return new IsoscelesTriangle();
            }
            else
            {
                return new ScaleneTriangle();
            }
        }
        }
    }
