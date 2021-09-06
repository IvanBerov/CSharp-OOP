using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stak = new StackOfStrings();

            stak.AddRange(new List<string>()
            {
                "123",
                "345",
                "678",
                "Gogo"
            });

            Console.WriteLine(stak.IsEmpty());

            foreach (var item in stak)
            {
                Console.WriteLine(item);
            }
        }
    }
}
