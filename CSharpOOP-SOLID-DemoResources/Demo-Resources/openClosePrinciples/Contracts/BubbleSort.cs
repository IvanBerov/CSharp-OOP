﻿using System;
using System.Collections.Generic;
using System.Text;

namespace openClosePrinciples.Contracts
{
    public class BubbleSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Bubble sort sux 0(n^2)");
            return list;
        }
    }
}
