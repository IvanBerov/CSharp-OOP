using System;
using System.Collections.Generic;
using System.Text;

namespace openClosePrinciples.Contracts
{
    public class HeapSort : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Heap sort is cool 0(n * log(n))");
            return list;
        }
    }
}
