using System;
using System.Collections.Generic;
using System.Text;

namespace openClosePrinciples.Contracts
{
    public class MergeSorter : ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Merge is good but not as fast as quick sort 0(n * log(n))");
            return list;
        }
    }
}
