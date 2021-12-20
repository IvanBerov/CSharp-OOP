using System;

namespace Hotel_Reservation
{
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private Discount discount;

        public PriceCalculator(string input)
        {
            var tokens = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var price = decimal.Parse(tokens[0]);
            var daysCount = int.Parse(tokens[1]);
            var seasonMultiplier = Enum.Parse<Season>(tokens[2]);

            Discount discountPercents = GetDiscountPercentage(tokens);


            this.pricePerDay = price;
            this.numberOfDays = daysCount;
            this.season = seasonMultiplier;
            this.discount = discountPercents;
        }

        public decimal CalculatePrice()
        {
            var price = this.pricePerDay * this.numberOfDays * (int)this.season;
            var discount = ((int)this.discount / 100.0m) * price;
            var calculatePrice = price - discount;

            return calculatePrice;
        }

        private static Discount GetDiscountPercentage(string[] tokens)
        {
            var discount = Discount.None;

            if (tokens.Length > 3)
            {
                discount = Enum.Parse<Discount>(tokens[3]);
            }

            return discount;
        }
    }
}
