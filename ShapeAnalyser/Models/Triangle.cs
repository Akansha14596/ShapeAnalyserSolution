﻿using ShapeAnalyser.Enums;

namespace ShapeAnalyser.Models
{
    public class Triangle : IShape
    {
        private double Side1 { get; }
        private double Side2 { get; }
        private double Side3 { get; }

        public Triangle(double[] sides)
        {
            Side1 = sides[0];
            Side2 = sides[1];
            Side3 = sides[2];
        }

        public ETriangleType DetermineType()
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                throw new ArgumentException("Sides must be greater than zero.");
            }

            if (Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1)
            {
                throw new ArgumentException("The given sides do not form a triangle.");
            }

            if (Side1 == Side2 && Side2 == Side3)
            {
                return ETriangleType.Equilateral;
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
            {
                return ETriangleType.Isosceles;
            }
            else
            {
                return ETriangleType.Scalene;
            }
        }
    }
}
