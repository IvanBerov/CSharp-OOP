using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Rules
{
    class BlackFridayRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Price + item.Price / 2;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("BLACKFRIDAY");
        }
    }
}
