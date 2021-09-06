using System;
using System.Collections.Generic;
using System.Text;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Drawers
{
    public class CircleDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("Drawing circle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
