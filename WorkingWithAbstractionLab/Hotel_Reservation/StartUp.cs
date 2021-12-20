using System;

namespace Hotel_Reservation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var priceCalc = new PriceCalculator(input);

            Console.WriteLine($"{priceCalc.CalculatePrice():f2}");
        }
    }
}
