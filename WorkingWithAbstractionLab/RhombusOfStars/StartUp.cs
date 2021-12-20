using System;

namespace RhombusOfStars
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusStringDrawer();
            var rhombusAsString = rhombusDrawer.Draw(n);

            Console.WriteLine(rhombusAsString);
        }
        
    }
}
