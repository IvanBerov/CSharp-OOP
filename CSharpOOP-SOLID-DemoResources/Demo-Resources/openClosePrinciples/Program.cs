using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace openClosePrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What strategy do you want ?");
            var strategyName = Console.ReadLine();

            var strategy = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => (typeof(ISortingStrategy).IsAssignableFrom(t)) && typeof(ISortingStrategy) != t)
                .First(t => t.Name.StartsWith(strategyName));

            ISortingStrategy sortingStrategy = (ISortingStrategy) Activator.CreateInstance(strategy);

            Sorter sorter = new Sorter(sortingStrategy);

            sorter.Sort(new List<int>());
        }
    }
}
