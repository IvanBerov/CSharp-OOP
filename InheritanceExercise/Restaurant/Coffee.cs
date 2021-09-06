

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal defaultPrice = 3.5M;
        private const double defaultMililiters = 50;
        public Coffee(string name, double caffeine)
            : base(name, defaultPrice, defaultMililiters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
