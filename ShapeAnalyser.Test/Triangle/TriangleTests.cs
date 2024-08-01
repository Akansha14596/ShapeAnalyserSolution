
using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Test.Triangle
{
    public class TriangleTests
    {
        [Test]
        public void TestEquilateralTriangle_Positive()
        {
            var triangle = new Models.Triangle(new double[] { 5, 5, 5 });
            Assert.That(triangle.DetermineType(), Is.EqualTo(ETriangleType.Equilateral));
        }

        [Test]
        public void TestIsoscelesTriangle_Positive()
        {
            var triangle = new Models.Triangle(new double[] { 5, 5, 7 });
            Assert.That(triangle.DetermineType(), Is.EqualTo(ETriangleType.Isosceles));
        }

        [Test]
        public void TestScaleneTriangle_Positive()
        {
            var triangle = new Models.Triangle(new double[] { 5, 6, 7 });
            Assert.That(triangle.DetermineType(), Is.EqualTo(ETriangleType.Scalene));
        }

        [Test]
        public void TestInvalidTriangle_Negative()
        {
            Assert.Throws<ArgumentException>(() => new Models.Triangle(new double[] { 1, 2, 3 }).DetermineType());
        }

        [Test]
        public void TestInvalidSides_Negative()
        {
            Assert.Throws<ArgumentException>(() => new Models.Triangle(new double[] { 0, 5, 5 }).DetermineType());
            Assert.Throws<ArgumentException>(() => new Models.Triangle(new double[] { -5, 5, 5 }).DetermineType());
        }
    }
}
