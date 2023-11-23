using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShapAreaLib.Area;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape: 1. Rectangle, 2. Square, 3. Circle, 4. Triangle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of Rectangle: {new Rectangle().Area(length, width)}");
                    break;

                case 2:
                    Console.Write("Enter side length: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of Square: {new Square().Area(side)}");
                    break;

                case 3:
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of Circle: {new Circle().Area(radius)}");
                    break;

                case 4:
                    Console.Write("Enter base length: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area of Triangle: {new Triangle().Area(baseLength, height)}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
