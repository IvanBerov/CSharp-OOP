using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            var employe = new Employee("Ivan Berov");

            var manager = new Manager("Bai Pesho", new[] {"first", "second", "third"});

            var detailPrinter = new DetailsPrinter(new List<Employee>(new[] {employe, manager}));

            Console.WriteLine(detailPrinter.PrintDetails());
        }
    }
}
