using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public override double Area => this.Side * this.Side;
    }
}
