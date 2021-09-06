using System;

namespace P02._DrawingShape_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager drawing = new DrawingManager();

            Player player = new Player();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            drawing.Draw(player);
            drawing.Draw(rectangle);
            drawing.Draw(circle);
            drawing.Draw(new Line());
        }
    }
}
