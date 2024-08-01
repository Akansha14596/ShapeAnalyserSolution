using ShapeAnalyser.Models;

namespace ShapeAnalyser.Factories
{
    public class ShapeFactory : IShapeFactory
    {
        /// <summary>
        /// Create Shape
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IShape CreateShape(double[] sides)
        {
            if (sides.Length != 3)
            {
                throw new ArgumentException("A triangle must have exactly three sides.");
            }

            return new Triangle(new double[] { sides[0], sides[1], sides[2] });         
        }
    }
 }
