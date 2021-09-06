using System;

namespace P01._Square_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Height = 9;
            rectangle.Width = 7;

            var rectangleArea = rectangle.Area;
            Console.WriteLine(rectangleArea);

            Square square = new Square();

            square.Side = 5;

            var squareArea = square.Area;
            Console.WriteLine(squareArea);

        }
    }
}
