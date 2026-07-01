using System;

namespace advance_geometry_helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Advanced Geometry Helper ===");
            Console.Write("please enter Enter the radius of the circle: ");
			
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleCircumference = radius * 2 * Math.PI;
            double area = Math.PI * radius * radius;
            double squareRoot = Math.Sqrt(radius);
            double cube = Math.Pow(radius, 3);
			
            Console.WriteLine("\\n------------------- Result -------------------");
            Console.WriteLine($"The circumference of this circle: {circleCircumference:F2}");
            Console.WriteLine($"The area of this circle: {area:F2}");
            Console.WriteLine($"The square root of the radius of this circle: {squareRoot:F2}");
            Console.WriteLine($"The cube of this circle: {cube:F2}");
            Console.WriteLine("----------------------------------------------");
			
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}