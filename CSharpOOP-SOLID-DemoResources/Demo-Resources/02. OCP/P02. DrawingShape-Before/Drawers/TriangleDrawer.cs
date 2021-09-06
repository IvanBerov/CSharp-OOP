using System;
using System.Collections.Generic;
using System.Text;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Drawers
{
    public class TriangleDrawer : IDrawer
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("Drawing triangle");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Triangle;
        }
    }
}
