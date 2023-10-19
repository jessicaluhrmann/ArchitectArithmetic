using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        public static void CalculateTotalCost()
        {
            var rectangleArea = Rectangles(2500, 1500);
            var circleArea = Circles(375) / 2;
            var triangleArea = Triangles(750, 500);
            var totalArea = rectangleArea + circleArea + triangleArea;
            var areaCost = Math.Round(totalArea * 180, 2);

            Console.WriteLine($"The total cost of flooring in Mexican Pesos will be {areaCost}.");
        }
        public static double Rectangles(double length, double width)
        {
            return length * width;
        }
        public static double Circles(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double Triangles(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
