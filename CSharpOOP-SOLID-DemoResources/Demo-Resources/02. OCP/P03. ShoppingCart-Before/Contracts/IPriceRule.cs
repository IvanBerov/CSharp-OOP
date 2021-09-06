using System;
using System.Collections.Generic;
using System.Text;
using P03._ShoppingCart;

namespace P03._ShoppingCart_Before.Contracts
{
    public interface IPriceRule
    {
        decimal CalculatePrice(OrderItem item);

        bool IsMatch(OrderItem item);

    }
}
